using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyDropdown : MonoBehaviour
{
    [SerializeField]
    Dropdown d;
    public void OnValChanged(Int32 i)
    {
        i = d.value;
        switch (i)
        {
            case 0:
                Settings.speed = -0.01f;
                break;
            case 1:
                Settings.speed = -0.05f;
                break;
            case 2:
                Settings.speed = -0.1f;
                break;
            default:
                Settings.speed = -0.01f;
                break;

        }

    }
}
