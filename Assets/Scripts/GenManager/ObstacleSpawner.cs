using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnObstacleTime = 1f;
    public float minOpawnObstacleTime = .25f;
    public float xSpawn = 3f;
    public Transform spawnParent;

    void Awake()
    {
        if (spawnParent == null)
            spawnParent = gameObject.transform;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (obstaclePrefabs.Length > 0)
        {
            StartCoroutine(SpawnObstacle());
        }
    }

    public void DecreaseSpawnTime(float amount)
    {
        spawnObstacleTime -= amount;
        spawnObstacleTime = Math.Max(minOpawnObstacleTime, spawnObstacleTime);
    }
    // // Update is called once per frame
    // void Update()
    // {

    // }
    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnObstacleTime);

            GameObject randomPrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
            Vector3 newSpawnPosition = transform.position;
            newSpawnPosition.x = Random.Range(-xSpawn, xSpawn);
            Instantiate(randomPrefab, newSpawnPosition, Random.rotation, spawnParent);
        }
    }
}