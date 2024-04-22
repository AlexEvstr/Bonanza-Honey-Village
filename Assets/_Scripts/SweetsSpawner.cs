using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _sweets;
    private float[] _xPosition = {-7f, -3.5f, 0f, 3.5f, 7f};

    private void Start()
    {
        StartCoroutine(SpawnRandomSweet());
    }

    private IEnumerator SpawnRandomSweet()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, _sweets.Length);
            int randomX = Random.Range(0, _xPosition.Length);
            GameObject sweet = Instantiate(_sweets[randomIndex]);
            sweet.transform.position = new Vector3(_xPosition[randomX], 7, 0);
            yield return new WaitForSeconds(Random.Range(1f, 3f));
        }
    }
}
