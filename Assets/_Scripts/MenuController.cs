using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private GameObject _skinsPanel;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private GameObject _howToPlay;
    private void Start()
    {
        Time.timeScale = 1;
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void PlayBtn()
    {
        int bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
        PlayerPrefs.SetInt("level", bestLevel);
        SceneManager.LoadScene("GameScene");
    }

    public void OpenLevelsPanel()
    {
        _levelsPanel.SetActive(true);
    }

    public void CloseLevelsPanel()
    {
        _levelsPanel.SetActive(false);
    }

    public void OpenSkinsPanel()
    {
        _skinsPanel.SetActive(true);
    }

    public void CloseSkinsPanel()
    {
        _skinsPanel.SetActive(false);
    }

    public void OpenSettingsPanel()
    {
        _settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        _settingsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlayButton()
    {
        _howToPlay.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        _howToPlay.SetActive(false);
    }
}