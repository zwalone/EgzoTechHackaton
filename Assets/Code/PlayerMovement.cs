using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    private float platformSize = 3.0f;

    bool egzoControl = false;

    // Start is called before the first frame update
    void Start()
    {
        if (EgzoController.instance != null)
        {
            egzoControl = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (egzoControl == false)
        {
            Vector3 position = this.transform.position;
            position.x += 0.5f;

            if (position.x > 2.5f)
                position.x--;
            else
                this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.5f;

            if (position.x < 0f)
                position.x++;
            else
                this.transform.position = position;

        }
        else
        {
            transform.position = new Vector3(ParseEgzoToLane(), transform.position.y, transform.position.z);

        }

    }



    float ParseEgzoToLane()
    {
        return (float)Math.Round(EgzoController.instance.axis.Value * 2,MidpointRounding.AwayFromZero) / 2;
    }
}