using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script describing behaviour of falling block
public class Block : MonoBehaviour
{


    public float length;
    public int laneNum;

    //Determine front and end of the block
    public Vector3 front;
    public Vector3 end;

   
    // Start is called before the first frame update
    void Start()
    {
        front = new Vector3(0, 0, transform.localPosition.z - (length / 2));
        end = new Vector3(0, 0, transform.localPosition.z + (length / 2));
    }




    // Update is called once per frame
    void Update()
    {
      
    }


    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, -0.1f));
    }



    //Play an animation that is triggered on collision with player object
    void PlayEffect()
    {

    }
    private void OnTriggerExit(Collider C)
    {
        this.transform.Find("Representation").position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z);
        this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("FFFFFF");
        GetComponent<Animator>().Play("Return");
    }
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {

            // this.transform.Find("Representation").position = new Vector3(this.transform.position.x, 0f, this.transform.position.z);
            GetComponent<Animator>().Play("Press");
            if (laneNum == 0)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("07A42E");
            }
            if (laneNum == 1)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("7DA40C");
            }
            if (laneNum == 2)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("D76A24");
            }
            if (laneNum == 3)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("D7184B");
            }
            if (laneNum == 4)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = ConvertHexToDec.GetColorfromString("CB16BF");
            }
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

