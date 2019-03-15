using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float platformSize = 1.0f;

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
            position.x += platformSize/5f;
            if (position.x >= platformSize)
                position.x -= platformSize / 5f;
            else
                this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= platformSize/5f;
            if (position.x < )
                position.x += platformSize /5f;
            else
                this.transform.position = position;
        }
    }

}
