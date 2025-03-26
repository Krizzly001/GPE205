using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ObjectScriptsUi : MonoBehaviour
{
    public AudioMixer mainAudioMixer;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMusicVolumeChange();
        OnSFXVolumeChange();
        
    }

    //FUNCTIONS
    public void OnMusicVolumeChange()
    {
        // Start with the slider value (assuming our slider runs from 0 to 1)
        float newVolume = musicVolumeSlider.value;
        if (newVolume <= 0) 
        {
            // If we are at zero, set our volume to the lowest value
            newVolume = -80;
        } 
        else 
        {
            // We are >0, so start by finding the log10 value 
            newVolume = Mathf.Log10(newVolume);
            // Make it in the 0-20db range (instead of 0-1 db)
            newVolume = newVolume * 20;
        }

        // Set the volume to the new volume setting
        mainAudioMixer.SetFloat("MusicVolume", newVolume);
    }
    public void OnSFXVolumeChange()
    {
        // Start with the slider value (assuming our slider runs from 0 to 1)
        float newVolume = sfxVolumeSlider.value;
        if (newVolume <= 0) 
        {
            // If we are at zero, set our volume to the lowest value
            newVolume = -80;
        } 
        else 
        {
            // We are >0, so start by finding the log10 value 
            newVolume = Mathf.Log10(newVolume);
            // Make it in the 0-20db range (instead of 0-1 db)
            newVolume = newVolume * 20;
        }

        // Set the volume to the new volume setting
        mainAudioMixer.SetFloat("SFXVolume", newVolume);
    }


    
}
