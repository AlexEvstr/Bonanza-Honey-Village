using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

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
                _winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
