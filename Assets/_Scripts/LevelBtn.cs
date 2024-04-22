using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelBtn : MonoBehaviour
{
    private int _bestLevel;

    private void Start()
    {
        _bestLevel = PlayerPrefs.GetInt("bestLevel", 1);

        if (_bestLevel >= int.Parse(gameObject.name))
        {
            gameObject.GetComponent<Button>().enabled = true;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }

        else
        {
            gameObject.GetComponent<Button>().enabled = false;
            gameObject.GetComponent<Image>().color = Color.grey;
        }
    }

    public void PickLvl()
    {
        SceneManager.LoadScene("GameScene");
        PlayerPrefs.SetInt("level", int.Parse(gameObject.name));
    }
}