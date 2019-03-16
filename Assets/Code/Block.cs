using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script describing behaviour of falling block
public class Block : MonoBehaviour
{

    
    public float length;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {
        transform.Translate(new Vector3(0,0,-0.1f));
    }



    //Play an animation that is triggered on collision with player object
    void PlayEffect()
    { 
    
    }
    
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(this.transform.position.x, 0f, this.transform.position.z);
            if(this.transform.position.x == -1)
            { 
                this.GetComponentInChildren<SpriteRenderer>().color = this.GetComponent<ConvertHexToDec>().GetColorfromString("259827");
            }
            if (this.transform.position.x == 0)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = this.GetComponent<ConvertHexToDec>().GetColorfromString("B9BF22");
            }
            if (this.transform.position.x == 1)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = this.GetComponent<ConvertHexToDec>().GetColorfromString("B2C323");
            }
            if (this.transform.position.x == 2)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = this.GetComponent<ConvertHexToDec>().GetColorfromString("B2C323");
            }
            if (this.transform.position.x == 3)
            {
                this.GetComponentInChildren<SpriteRenderer>().color = this.GetComponent<ConvertHexToDec>().GetColorfromString("B2C323");
            }
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(this.transform.position.x, 0.5f, this.transform.position.z);
        }
    }
    
  

    void OnTriggerStay(Collider other)
    { 
        if(other.gameObject.tag == "Player")
        {
            Player.instance.Score++;
            PlayEffect();
            Player.instance.GetComponent<ParticleSystem>().Emit(10);
        }
    }
}
