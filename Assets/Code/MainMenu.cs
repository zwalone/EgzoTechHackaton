using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// UI Utility class - Changes scenes
/// </summary>
public class MainMenu : MonoBehaviour
{

    /// <summary>
    /// Changes the scenes.
    /// </summary>
    /// <param name="name">Name of a scene to change to</param>
    public void changeScenes(string name)
    {
        Application.LoadLevel(name);
    }
}
