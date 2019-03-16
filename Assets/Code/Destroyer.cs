using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///Destroys unused instances of blocks that have fallen out of map borders
public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    { 
        if(c.tag == "Block")
        {
            Destroy(c.gameObject);
        }
    }
}
