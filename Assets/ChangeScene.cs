using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    InputField field;

    public void changeScenes(string name)
    {
        Application.LoadLevel(name);
        Player.sessionTime = 60f * int.Parse(field.text);
    }
}
