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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            Vector3 position = this.transform.position;
            position.x += 1.0f;
            if (position.x > platformSize)
                position.x -= 1.0f;
            else
                this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= 1.0f;
            if (position.x < -1.0f)
                position.x += 1.0f;
            else
                this.transform.position = position;
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.right, 1f);
    }

}