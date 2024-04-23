using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAndVibro : MonoBehaviour
{
    [SerializeField] private GameObject _musicOff;
    [SerializeField] private GameObject _musicOn;
    [SerializeField] private GameObject _vibroOff;
    [SerializeField] private GameObject _vibroOn;
    public static bool CanVibro;

    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume", 1);
        if (AudioListener.volume == 1)
        {
            _musicOff.SetActive(false);
            _musicOn.SetActive(true);
        }
        else
        {
            _musicOff.SetActive(true);
            _musicOn.SetActive(false);
        }

        Vibration.Init();
        string vibro = PlayerPrefs.GetString("vibro", "");
        if (vibro == "" || vibro == "on") VibroTurnOn();
        else VibroTurnOff();
    }

    public void MusicOff()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _musicOff.SetActive(true);
        _musicOn.SetActive(false);
        AudioListener.volume = 0;
        PlayerPrefs.SetFloat("volume", 0);
    }

    public void MusicOn()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _musicOff.SetActive(false);
        _musicOn.SetActive(true);
        AudioListener.volume = 1;
        PlayerPrefs.SetFloat("volume", 1);
    }

    public void VibroTurnOff()
    {
        CanVibro = false;
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _vibroOff.SetActive(true);
        _vibroOn.SetActive(false);
        
        PlayerPrefs.SetString("vibro", "off");
    }

    public void VibroTurnOn()
    {
        CanVibro = true;
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _vibroOff.SetActive(false);
        _vibroOn.SetActive(true);

        PlayerPrefs.SetString("vibro", "on");
    }
}