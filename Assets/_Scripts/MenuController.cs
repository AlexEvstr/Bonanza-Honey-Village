using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private GameObject _skinsPanel;
    [SerializeField] private GameObject _settingsPanel;
    private void Start()
    {
        Time.timeScale = 1;
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void PlayBtn()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        int bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
        PlayerPrefs.SetInt("level", bestLevel);
        SceneManager.LoadScene("GameScene");
    }

    public void OpenLevelsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _levelsPanel.SetActive(true);
    }

    public void CloseLevelsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _levelsPanel.SetActive(false);
    }

    public void OpenSkinsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _skinsPanel.SetActive(true);
    }

    public void CloseSkinsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _skinsPanel.SetActive(false);
    }

    public void OpenSettingsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _settingsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        if (SoundAndVibro.CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        Application.Quit();
    }
}