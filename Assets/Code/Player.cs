using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    //====== SINGLETON ======
    public static Player instance = null;
    public Text scoreText;


    public float time;
    public static float sessionTime;

    long score = 0;
    public long Score
    { 
        get { return score; }
        set { score = value; scoreText.text = "Wynik: " + score.ToString(); }
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

    void FixedUpdate()
    {
        if(sessionTime != 0)
        {
            time += Time.deltaTime;
            if(time >= sessionTime)
            {
                //TODO: End game;
                Debug.LogWarning("ENDDDDD YEEEEEEEEEEE");
            }
        }


    }


}
