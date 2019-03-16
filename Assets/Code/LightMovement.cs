using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    static Vector3 pos;
    static Quaternion rotate;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        rotate = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
