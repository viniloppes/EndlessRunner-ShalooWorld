
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{

    public GameObject fencePrefab;
    [SerializeField] private bool HasObstacles = false;
    public GameObject lifePrefab;
    public GameObject coinPrefab;

    public float[] lanes = { -3f, 0f, 3f };
    List<int> lanesAvaliable = new List<int>() { 0, 1, 2 };

    public float lifeSpawnChance = .3f;
    public float coinSpawnChance = .5f;

    public int maxCoinPerChunk = 5;

    public float coinSeparationLength = 2f;
    
    private LevelGenerator _levelGenerator ;
    private ScoreManager _scoreManager;
    public void Init(LevelGenerator levelGenerator,  ScoreManager scoreManager)
    {
        this._levelGenerator = levelGenerator;
        this._scoreManager = scoreManager;
    }
    void Start()
    {
        SpawnLanes();
        SpawnLife();
        SpawnCoin();
    }

    void SpawnLanes()
    {

        if (HasObstacles == false) return;
        int lanesToSpawn = Random.Range(0, lanesAvaliable.Count);
        for (int i = 0; i < lanesToSpawn; i++)
        {

            if (lanesAvaliable.Count <= 0) break;
            int selectedLane = SelectRandomLane();
            Vector3 spawnPos = new Vector3(lanes[selectedLane], transform.position.y, transform.position.z);
            Instantiate(fencePrefab, spawnPos, Quaternion.identity, this.transform);
        }


    }

    private int SelectRandomLane()
    {
        int randomLaneIndex = Random.Range(0, lanesAvaliable.Count);
        int selectedLane = lanesAvaliable[randomLaneIndex];
        lanesAvaliable.RemoveAt(randomLaneIndex);
        return selectedLane;
    }

    void SpawnLife()
    {
        if (lanesAvaliable.Count <= 0) return;
        if (Random.value > lifeSpawnChance) return;

        int selectedLane = SelectRandomLane();
        Vector3 spawnPos = new Vector3(lanes[selectedLane], transform.position.y, transform.position.z);
        Apple newApple = Instantiate(lifePrefab, spawnPos, Quaternion.identity, this.transform).GetComponent<Apple>();
        newApple.Init(_levelGenerator);
    }

    void SpawnCoin()
    {
        if (lanesAvaliable.Count <= 0) return;
        if (Random.value > coinSpawnChance) return;

        float topOfChunk = transform.position.z + (coinSeparationLength * 2);
        int coinsToSpawn = Random.Range(1, maxCoinPerChunk + 1);

        int selectedLane = SelectRandomLane();
        for (int i = 0; i < coinsToSpawn; i++)
        {

            float zSpawnPosition = topOfChunk - (i * coinSeparationLength);
            Vector3 spawnPos = new Vector3(lanes[selectedLane], transform.position.y, zSpawnPosition);
            Coin newCoint = Instantiate(coinPrefab, spawnPos, Quaternion.identity, this.transform).GetComponent<Coin>();
            newCoint.Init(_scoreManager);
        }

    }
}
