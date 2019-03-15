using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //====== SINGLETON ======
    public static Player instance = null;

    public long score = 0;




    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
