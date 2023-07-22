using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSave : MonoBehaviour
{
    public Slider soundSlider;
    void Awake()
    {
        if (!PlayerPrefs.HasKey("soundValue"))
        {
            PlayerPrefs.SetFloat("soundValue", 1);
            PlayerPrefs.Save();
        }
        soundSlider.value = PlayerPrefs.GetFloat("soundValue");
    }
    void Update()
    {
        soundSlider.onValueChanged.AddListener(delegate { SafeValue(); });
    }

    public void SafeValue()
    {
        PlayerPrefs.SetFloat("soundValue", soundSlider.value);
        PlayerPrefs.Save();
        Debug.Log("Saved");
    }
}
