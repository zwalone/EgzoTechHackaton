using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusinOnAndOff : MonoBehaviour
{
    AudioSource audioSource;
    

    public void PlayMusic()
    {
        bool musicPlay = true;

        audioSource = GetComponent<AudioSource>();


        if (musicPlay == false)
            audioSource.Play();
        else
        {
            audioSource.Pause();
            musicPlay = true;
        }
    }
}
