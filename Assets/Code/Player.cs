using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //====== SINGLETON ======
    public static Player instance = null;


    long score = 0;
    public long Score
    { 
        get { return score; }
        set { score = value;  }
    }


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
