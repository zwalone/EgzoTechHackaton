using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioClip[] sounds;

    private void Start()
    {
        GetComponent<AudioSource>().clip = sounds[Random.Range(0, sounds.Length)];
        GetComponent<AudioSource>().Play();
    }
}
