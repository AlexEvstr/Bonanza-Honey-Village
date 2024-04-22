using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagColorGame : MonoBehaviour
{
    [SerializeField] private Color[] _colors; 

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = _colors[PlayerPrefs.GetInt("bagColor", 0)];
        transform.GetChild(0).GetComponent<SpriteRenderer>().color = _colors[PlayerPrefs.GetInt("bagColor", 0)];
    }
}
