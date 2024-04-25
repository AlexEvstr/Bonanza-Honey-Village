using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{
    [SerializeField] private GameObject _pause;
    [SerializeField] private Image _gameTutorial;
    [SerializeField] private TMP_Text _gameTutorialText;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Time.timeScale = 1;
        StartCoroutine(HideTutorial());
    }

    private IEnumerator HideTutorial()
    {
        float colorA = 1.0f;
        Destroy(_gameTutorial, 4.5f);
        Destroy(_gameTutorialText, 4.5f);
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            yield return new WaitForSeconds(0.001f);
            
            colorA -= 0.001f;
            Debug.Log(colorA);
            _gameTutorial.color = new Color(1, 1, 1, colorA);
            _gameTutorialText.color = new Color(0.45f, 0.45f, 0.45f, colorA);
        }
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
