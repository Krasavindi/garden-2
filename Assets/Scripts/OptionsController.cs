using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultVolume = 0.5f;
    [SerializeField] float defaultDifficulty = 1;
     void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetMasterDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        VolumeController();
    }

    private void VolumeController()
    {
        var musicPlayer = FindObjectOfType<MusicPlayerScript>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);

        }
        else
        {
            Debug.LogWarning("No music player found.. did you start from splash screen?");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetMasterDifficulty(difficultySlider.value);
        FindObjectOfType<goToStart>().LoadMainMenu();

    }
    public void SetDefualts()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
        
        
    }
}
