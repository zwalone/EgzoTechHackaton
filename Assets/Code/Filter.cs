using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter : MonoBehaviour
{
    public event Action<Block> BlockEntered;

    void Awake()
    {

    }


    void OnTriggerExit(Collider other)
    { 
        if(other.tag == "Block")
        {
            BlockEntered(other.GetComponent<Block>());
        }
    }

}
