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

    private void OnTriggerEnter(Collider c)
    {

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
        if (other.gameObject.tag == "Player")
        {
            Player.instance.Score++;
            PlayEffect();
            Player.instance.GetComponent<ParticleSystem>().Emit(10);
        }
    }
}

