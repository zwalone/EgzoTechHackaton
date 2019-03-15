using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script describing behaviour of falling block
public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Play an animation that is triggered on collision with player object
    void PlayEffect()
    { 
    
    }

    void OnCollisionEnter(Collision c)
    { 
        if(c.collider.gameObject.tag == "PlayerObject")
        {
            Player.instance.score++;
            PlayEffect();
        }
    }
}
