using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipePick : MonoBehaviour
{
    [SerializeField] private GameObject _basicSpark;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(clickPos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("BadFood"))
            {
                
                GameObject spark = Instantiate(_basicSpark);
                spark.transform.position = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z);
                Destroy(spark, 0.25f);
                Destroy(hit.collider.gameObject);
                GetComponent<GameSounds>().FoodDestroySound();
            }
        }
    }
}