using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Contains trigger behaviour, when Block exits from trigger, this class will call
/// to generate another block
/// </summary>
public class Filter : MonoBehaviour
{
    /// <summary>
    /// Occurs when block entered the trigger field.
    /// </summary>
    public event Action<Block> BlockExited;

    void Awake()
    {
        //set filter position
        transform.position = new Vector3(0,0,Settings.ZSpawn);

    }


    void OnTriggerExit(Collider other)
    { 
        if(other.tag == "Block")
        {
            BlockExited(other.GetComponent<Block>());
        }
    }

}
