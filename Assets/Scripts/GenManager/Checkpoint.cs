using System;
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private float timeToIncrease = 5.0f;
    [SerializeField] private float spawnTimeDecrease = .1f;

    private string playerTagString = "Player";
    private GameManager gameManager;
    private ObstacleSpawner obstacleSpawner;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        obstacleSpawner = FindFirstObjectByType<ObstacleSpawner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTagString))
        {
            gameManager.IncreaseTime(timeToIncrease);
            obstacleSpawner.DecreaseSpawnTime(spawnTimeDecrease);
        }
    }
}