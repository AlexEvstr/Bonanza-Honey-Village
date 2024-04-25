using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagControl : MonoBehaviour
{
    private float _speed = 30.0f;
    private void FixedUpdate()
    {
        transform.Translate(Input.acceleration.x * Time.deltaTime * _speed, 0, 0);
    }
}
