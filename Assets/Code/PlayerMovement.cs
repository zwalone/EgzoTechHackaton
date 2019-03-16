﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    private float platformSize = 3.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EgzoController.instance.alive == false)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector3 position = this.transform.position;
                position.x += 0.5f;

                if (position.x > 2.5f)
                    position.x -= 0.5f;
                this.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector3 position = this.transform.position;
                position.x -= 0.5f;

                if (position.x < 0f)
                    position.x += 0.5f;

                this.transform.position = position;
            }
        }


        if (EgzoController.instance.alive == true)
        {
            //  transform.position = new Vector3(ParseEgzoToLane(), transform.position.y, transform.position.z);
            transform.position = new Vector3(EgzoController.instance.axis.Value, transform.position.y, transform.position.z);
        }

    }



    float ParseEgzoToLane()
    {
        return (float)Math.Round(EgzoController.instance.axis.Value * 2, MidpointRounding.AwayFromZero) / 2;
    }
}