using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSave : MonoBehaviour
{
    public Slider soundSlider;
    public AudioSource audio;
    public float volume;

    void Start()
    {
        Load();
        ValueMusic();
    }
    
    public void SliderMusic()
    {
        volume = soundSlider.value;
        Save();
        ValueMusic();
    }

    void ValueMusic()
    {
        audio.volume = volume;
        soundSlider.value = volume;
    }

    void Save()
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    void Load()
    {
        volume = PlayerPrefs.GetFloat("volume", volume);
    }
}
