using UnityEngine;

public class BagControl2 : MonoBehaviour
{
    private float _movementSpeed = 0.01f;
    private Touch _touch;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            transform.position = new Vector2(transform.position.x + _touch.deltaPosition.x * _movementSpeed, transform.position.y);
        }   
    }
}