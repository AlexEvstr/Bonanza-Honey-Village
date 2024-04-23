using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

    private void Awake()
    {
        int control = PlayerPrefs.GetInt("control", 1);
        if (control == 1)
        {
            GetComponent<BagControl2>().enabled = false;
        }
        else
        {
            GetComponent<BagControl>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            Destroy(collision.gameObject);
            SweetsCounter.SweetAmount++;

            if (SweetsCounter.SweetAmount == 20)
            {
                LevelController.Level++;
                PlayerPrefs.SetInt("level", LevelController.Level);
                int bestLevel = PlayerPrefs.GetInt("bestLevel", 1);
                if (bestLevel < LevelController.Level)
                {
                    bestLevel = LevelController.Level;
                    PlayerPrefs.SetInt("bestLevel", bestLevel);
                }
                _winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
