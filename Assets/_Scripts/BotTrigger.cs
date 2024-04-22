using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _gemeoverPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            Destroy(collision.gameObject);
            _gemeoverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
