using System;
using UnityEngine;
using WebSocketSharp;
using Newtonsoft.Json;

public class EgzoController : MonoBehaviour
{

    public static EgzoController instance;
    WebSocket socket;

    //Input value from WebSocketConnection
    public Axis axis;



    void Start()
    {
        if (instance == null)
        {
            instance = this;
            axis = new Axis();

        }
        EstablishConnection();
    }

    void EstablishConnection()
    {

        if (socket == null)
        {
            socket = new WebSocket("ws://192.168.102.219:1234/bG9zb3NpZQ==");
        }
        socket.Connect();

        //after connection is established, go and link events
        socket.OnOpen += OnConnectionOpened;
        socket.OnClose += OnConnectionClosed;
        socket.OnMessage += OnDataReceived;
    }

    void EstablishConnection(string address)
    {
        if (socket == null)
        {
            socket = new WebSocket(address);
        }
        socket.Connect();
    }

    void OnConnectionClosed(object sender, EventArgs e)
    {
        Debug.Log("Connection opened");
    }

    void OnConnectionOpened(object sender, EventArgs e)
    {
        Debug.Log("Connection closed");
    }

    void OnDataReceived(object sender, MessageEventArgs e)
    {
        //retreive JSON message
        string JSONraw = e.Data;
        axis = JsonConvert.DeserializeObject<Axis>(JSONraw);
        Debug.Log(axis.value);
    }

    public class Axis
    {
        public float value;
    }



}

