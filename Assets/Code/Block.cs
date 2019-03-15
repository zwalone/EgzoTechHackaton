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
           // Player.instance.GetComponent<ParticleSystem>().enableEmission = true;

        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            //Player.instance.GetComponent<ParticleSystem>().enableEmission = false;
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
