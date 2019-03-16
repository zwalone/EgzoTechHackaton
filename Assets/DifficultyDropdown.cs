using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that contains difficulty presets, also contains behaviour for dropdown difficulty choosers
/// </summary>
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
                Settings.speed = 0.03f;
                Settings.ZSpawn = 10f;
                break;
            case 1:
                Settings.speed = 0.05f;
                Settings.ZSpawn = 10f;
                break;
            case 2:
                Settings.speed = 0.07f;
                Settings.ZSpawn = 15f;
                break;
            case 3:
                Settings.speed = 0.1f;
                Settings.ZSpawn = 20f;
                break;
            default:
                Settings.speed = 0.05f;
                Settings.ZSpawn = 10f;
                break;

        }

    }
}
