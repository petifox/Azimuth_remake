using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioMixer musicMixer;


    public void SetFulscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
        Debug.Log(fullscreen);
    }

    public void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat("Volume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        musicMixer.SetFloat("Volume", volume);
    }
}
