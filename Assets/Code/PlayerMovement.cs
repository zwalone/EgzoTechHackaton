using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
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
    }

}