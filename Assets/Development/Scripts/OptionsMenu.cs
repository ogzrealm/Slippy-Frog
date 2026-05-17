using System;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private Slider bgSlider;
    [SerializeField] private Slider effectSlider;

    private void Start()
    {
        SetBGVolume();
        SetEffectVolume();
    }

    private void SetBGVolume()
    {
        float savedVolume=PlayerPrefs.GetFloat("BGVolume",1f);
        bgSlider.value=savedVolume;

        bgSlider.onValueChanged.AddListener(BackGroundVolume);
    }
    
    public void BackGroundVolume(float volume)
    {
        PlayerPrefs.SetFloat("BGVolume",volume);
        PlayerPrefs.Save();
    }

    
    private void SetEffectVolume()
    {
        float savedVolume = PlayerPrefs.GetFloat("EffectVolume",0.3f);
        effectSlider.value=savedVolume;
        
        effectSlider.onValueChanged.AddListener(EffectVolume);
    }
    
    public void EffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("EffectVolume",volume);
        PlayerPrefs.Save();
    }
}
