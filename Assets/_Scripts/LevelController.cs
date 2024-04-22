using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    [SerializeField] private TMP_Text _lvlText;
    public static int Level;

    private void Start()
    {
        Level = PlayerPrefs.GetInt("level", 1);
        _lvlText.text = "Level:" + Level;
    }
}
