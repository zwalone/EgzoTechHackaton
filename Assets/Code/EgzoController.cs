using System;
using UnityEngine;
using WebSocketSharp;
using Newtonsoft.Json;


/// <summary>
/// EgzoTech, Luna controller - uses webSocket to communicate with rehabilitation device, and exchanges the signal
/// into appropiate values for in game use // DontDestroyOnLoad // Singleton
/// </summary>
public class EgzoController : MonoBehaviour
{
    //singleton
    public static EgzoController instance = null;
    public bool alive = false;
    WebSocket socket = null;

    //Input value from WebSocketConnection
    public Axis axis;


    void Start()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        axis = new Axis();
        DontDestroyOnLoad(this.gameObject);

    }

    void EstablishConnection()
    {
        if (socket == null)
        {
            socket = new WebSocket("ws://192.168.102.219:1234/bG9zb3NpZQ==");
            //after connection is established, go and link events
            socket.OnOpen += OnConnectionOpened;
            socket.OnClose += OnConnectionClosed;
            socket.OnError += OnError;
            socket.OnMessage += OnDataReceived;
        }
        socket.Connect();
    }

    public void EstablishConnection(string address)
    {
        if (socket == null)
        {
            socket = new WebSocket(address);
            //after connection is established, go and link events
            socket.OnOpen += OnConnectionOpened;
            socket.OnClose += OnConnectionClosed;
            socket.OnError += OnError;
            socket.OnMessage += OnDataReceived;
        }
        socket.Connect();
    }

    void OnConnectionClosed(object sender, EventArgs e)
    {
        Debug.Log("Connection closed");
        alive = false;
    }

    void OnConnectionOpened(object sender, EventArgs e)
    {
        Debug.Log("Connection opened");
        alive = true;
    }

    void OnError(object sender, ErrorEventArgs e)
    {
        Debug.Log("Connection error: " + e.Message);
        socket.Close();
    }


    void OnDataReceived(object sender, MessageEventArgs e)
    {
        //retreive JSON message
        string JSONraw = e.Data;
        axis = JsonConvert.DeserializeObject<Axis>(JSONraw);
        Debug.Log(axis.Value);
    }

    public class Axis
    {
        float val;
        public float Value
        {
            get { return val; }
            set { val = value + 1; }
        }
    }


    void OnApplicationQuit()
    {
        //safely close connection 
        if (socket != null)
            socket.Close();
    }


}

