using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///<summary>Destroys unused instances of blocks that have fallen out of map borders</summary>
public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Block")
        {
            Destroy(c.gameObject);
        }
    }
}
