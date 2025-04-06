using UnityEngine;
using System.Collections;

public class FallingObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnInterval = 2f;
    public float spawnRangeX = 20f;
    public float spawnHeight = 40f;
    public float objectLifetime = 10f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnHeight, 0f);
            GameObject fallingObject = Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
            Destroy(fallingObject, objectLifetime);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
