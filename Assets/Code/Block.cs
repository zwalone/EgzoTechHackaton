using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script describing behaviour of falling block
public class Block : MonoBehaviour
{


    public float length;
    public int laneNum;

    static Color lastColour;
    public static event Action<Color> colorChanged;
    public static Color LastColour
    {
        get { return lastColour; }
        set { lastColour = value; colorChanged(lastColour); }
    }

    //Determine front and end of the block
    public Vector3 front;
    public Vector3 end;

    private GameObject lightplayer;
    // Start is called before the first frame update
    void Start()
    {
        front = new Vector3(0, 0, transform.localPosition.z - (length / 2));
        end = new Vector3(0, 0, transform.localPosition.z + (length / 2));
        lightplayer = GameObject.FindGameObjectWithTag("LightPlayer");
    }




    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, -Settings.speed));
    }



    //Play an animation that is triggered on collision with player object
    void PlayEffect()
    {

    }


    private void OnTriggerExit(Collider C)
    {
        //Player.instance.GetComponentInChildren<Light>().enabled = false;
        lightplayer.GetComponent<Light>().enabled = false;
        this.transform.Find("Representation").position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z);
        this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("FFFFFF");
        GetComponent<Animator>().Play("Return");
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            
            GetComponent<Animator>().Play("Press");
            if (laneNum == 0)
            {
                lightplayer.GetComponent<Light>().enabled = true;
                lightplayer.GetComponent<Light>().color = ConvertHexToDec.GetColorfromString("07A42E");
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("07A42E");
            }
            if (laneNum == 1)
            {
                lightplayer.GetComponent<Light>().enabled = true;
                lightplayer.GetComponent<Light>().color = ConvertHexToDec.GetColorfromString("7DA40C");
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("7DA40C");
            }
            if (laneNum == 2)
            {
                lightplayer.GetComponent<Light>().enabled = true;
                lightplayer.GetComponent<Light>().color = ConvertHexToDec.GetColorfromString("D76A24");
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("D76A24");
            }
            if (laneNum == 3)
            {
                lightplayer.GetComponent<Light>().enabled = true;
                lightplayer.GetComponent<Light>().color = ConvertHexToDec.GetColorfromString("D7184B");
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("D7184B");
            }
            if (laneNum == 4)
            {
                lightplayer.GetComponent<Light>().enabled = true;
                lightplayer.GetComponent<Light>().color = ConvertHexToDec.GetColorfromString("CB16BF");
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("CB16BF");
            }
            LastColour = this.GetComponentInChildren<SpriteRenderer>().color;
            gameObject.GetComponentInChildren<SpriteRenderer>().material.SetColor("_MKGlowColor", LastColour);
          
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.instance.Score++;
            PlayEffect();
            Player.instance.GetComponent<ParticleSystem>().Emit(4);
        }
    }

   
}
