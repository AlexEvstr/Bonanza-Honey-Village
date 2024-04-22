using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{
    [SerializeField] private GameObject _pause;

    private void Start()
    {
        Time.timeScale = 1;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void PauseGame()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void MenuBack()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Replay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
