using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    AudioSource audioSource;
    bool isPlaying = false;
    void Start()
    {
        while(isPlaying)
        {
            DontDestroyOnLoad(this);
            isPlaying = true;
        }
        
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        
    }
}
