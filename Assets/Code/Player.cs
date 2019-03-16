using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class that stores player score
//And UI references
public class Player : MonoBehaviour
{

    //====== SINGLETON ======
    public static Player instance = null;
    public Text scoreText;
    public Text clockText;

    float time;
    public float _Time
    { 
        get { return time;  }
        set { time = value; OnTimeUpdate(); }
    }
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
        Block.colorChanged += OnColorUpdate;
        _Time = sessionTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(sessionTime != 0)
        {
            _Time -= Time.deltaTime;
            if(_Time <= 0)
            {
                //TODO: End game;
                Application.LoadLevel("MainMenu");
            }
        }


    }

    void OnTimeUpdate()
    {
        if(sessionTime == 0)
        {
            clockText.transform.parent.gameObject.SetActive(false);
        }
        clockText.text = "Pozostały czas: " + Mathf.RoundToInt(_Time).ToString();

    }


    void OnColorUpdate(Color color)
    {
        //Select glow material and update it's glow color depending on lastest block color
        gameObject.GetComponent<MeshRenderer>().materials[1].SetColor("_MKGlowColor", color);
    }


}
