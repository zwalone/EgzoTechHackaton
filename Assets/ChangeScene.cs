using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// UI Utility Class - For convinient changing of scenes
/// </summary>
public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    InputField field;

    /// <summary>
    /// Changes the scene to scene with a given name
    /// </summary>
    /// <param name="name">Name of a scene</param>
    public void changeScenes(string name)
    {
        Application.LoadLevel(name);
        Player.sessionTime = 60f * int.Parse(field.text);
    }
}
