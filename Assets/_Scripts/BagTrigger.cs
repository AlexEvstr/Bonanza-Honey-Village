using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            Destroy(collision.gameObject);

        }
    }
}
