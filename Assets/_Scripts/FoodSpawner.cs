using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _food;
    private float[] _xPosition = { -7f, -3.5f, 0f, 3.5f, 7f };

    private void Start()
    {
        StartCoroutine(SpawnRandomFood());
    }

    private IEnumerator SpawnRandomFood()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, _food.Length);
            int randomX = Random.Range(0, _xPosition.Length);
            GameObject food = Instantiate(_food[randomIndex]);
            StartCoroutine(MakeOutOfPipeSound());
            food.transform.position = new Vector3(_xPosition[randomX], 7, 0);
            yield return new WaitForSeconds(Random.Range(3f, 4f));
        }
    }

    private IEnumerator MakeOutOfPipeSound()
    {
        yield return new WaitForSeconds(4.5f);
        GetComponent<GameSounds>().OutOfPipeSound();
    }
}
