using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void changeScenes(string name)
    {
        Application.LoadLevel(name);
    }
}
