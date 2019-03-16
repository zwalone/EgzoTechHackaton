using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Triggers creation of new blocks
public class Filter : MonoBehaviour
{
    public event Action<Block> BlockEntered;

    void Awake()
    {
        //set filter position
        transform.position = new Vector3(0,0,Settings.ZSpawn);

    }


    void OnTriggerExit(Collider other)
    { 
        if(other.tag == "Block")
        {
            BlockEntered(other.GetComponent<Block>());
        }
    }

}
