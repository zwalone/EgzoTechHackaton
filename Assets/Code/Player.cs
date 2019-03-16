using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Class that stores player score
///And UI references
/// \\
/// Singleton</summary>
public class Player : MonoBehaviour
{

    //====== SINGLETON ======
    public static Player instance = null;
    public Text scoreText;
    public Text clockText;

    float time;
    /// <summary>
    /// Gets and sets time, and calls OnTimeUpdate method which will update clockText variable with amount of time left
    /// </summary>
    /// <value>The time.</value>
    public float _Time
    { 
        get { return time;  }
        set { time = value; OnTimeUpdate(); }
    }
    public static float sessionTime;

    long score = 0;
    ///<summary>Score property - Setting it automatically will set the scoreText.text variable to show current score</summary>
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

    //Updates clock UI
    void OnTimeUpdate()
    {
        if(sessionTime == 0)
        {
            clockText.transform.parent.gameObject.SetActive(false);
        }
        clockText.text = "Czas: " + Mathf.RoundToInt(_Time).ToString();

    }

    //Select glow material and update it's glow color depending on lastest block color
    void OnColorUpdate(Color color)
    {
        gameObject.GetComponent<MeshRenderer>().materials[1].SetColor("_MKGlowColor", color);
    }


}
