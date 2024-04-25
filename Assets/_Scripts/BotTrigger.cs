using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _gemeoverPanel;
    [SerializeField] private GameSounds _gameSounds;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy") || collision.gameObject.CompareTag("BadFood"))
        {
            Destroy(collision.gameObject);
            _gameSounds.LoseSound();
            _gemeoverPanel.SetActive(true);
            Time.timeScale = 0;
            _gameSounds.GameOverSound();
        }
    }
}
