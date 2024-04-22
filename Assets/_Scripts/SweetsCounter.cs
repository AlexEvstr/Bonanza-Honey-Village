using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SweetsCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _sweetsText;
    public static int SweetAmount;

    private void Start()
    {
        SweetAmount = 0;
    }

    private void Update()
    {
        _sweetsText.text = $"{SweetAmount}/20";
    }
}
