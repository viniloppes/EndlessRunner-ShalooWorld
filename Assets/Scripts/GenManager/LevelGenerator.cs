using System;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    [Header("References")] [SerializeField]
    private Transform chunkParent;

    [SerializeField] private GameObject checkpointChunkPrefab;
    [SerializeField] private GameObject[] chunksPrefab;
    [SerializeField] private CameraController _cameraController;
    [SerializeField] private ScoreManager scoreManager;

    [Header("Level Settings")] [Tooltip("The amount of chunks we start with")] [SerializeField]
    private int startingChunkAmount = 12;

    [Tooltip("Do not change chunk length value unless chunk prefab size reflects change")] 
    [SerializeField] private float chunkLength = 10.0f;
    [SerializeField] private int checkpointChunkIntervale = 10;

    [SerializeField] private float minChunckSpeed = 2.0f;
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float minMoveSpeed = 2f;
    [SerializeField] private float maxMoveSpeed = 22f;
    [SerializeField] private float minGravityZ = -20f;
    [SerializeField] private float maxGravityZ = -2f;

    List<GameObject> chunks = new List<GameObject>();
    CinemachineCamera cinemachineCamera;

    private int _spawnedChunkAmount;

    void Start()
    {
        SpawnStartingChunks();
    }


    void Update()
    {
        MoveChunks();
    }

    public void ChangeSpeed(float speedAmount)
    {
        float newMoveSpeed = moveSpeed + speedAmount;
        newMoveSpeed = Mathf.Clamp(newMoveSpeed, minMoveSpeed, maxMoveSpeed);
        if (newMoveSpeed != moveSpeed)
        {
            moveSpeed = newMoveSpeed;
            float newGravityZ = Physics.gravity.z - speedAmount;
            newGravityZ = Math.Clamp(newGravityZ, minGravityZ, maxGravityZ);
            Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y, newGravityZ);
            _cameraController.ChangeCameraFOV(speedAmount);
        }
    }

    void MoveChunks()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            GameObject chunk = chunks[i];
            chunk.transform.Translate(-Vector3.forward * (moveSpeed * Time.deltaTime));
            if (chunk.transform.position.z <= Camera.main.transform.position.z - chunkLength)
            {
                Destroy(chunk);
                chunks.Remove(chunk);
                SpawnRandomChunck();
            }
        }
    }

    void SpawnStartingChunks()
    {
        for (int i = 0; i < startingChunkAmount; i++)

        {
            SpawnRandomChunck();
        }
    }

    void SpawnRandomChunck()
    {
        if (_spawnedChunkAmount % checkpointChunkIntervale == 0 && _spawnedChunkAmount > 0)
        {
            SpawnChunk(checkpointChunkPrefab);
        }
        else
        {
            int prefabIndex = Random.Range(0, chunksPrefab.Length);
            SpawnChunk(chunksPrefab[prefabIndex]);
        }
    }

    void SpawnChunk(GameObject chunkPrefab)
    {
        float spawnPosZ = CalculateSpawnPositionZ();

        Vector3 newPos =
            new Vector3(
                chunkPrefab.transform.position.x,
                chunkPrefab.transform.position.y,
                spawnPosZ
            );
        GameObject chunk = Instantiate(chunkPrefab, newPos, Quaternion.identity, chunkParent);
        Chunk newChunk = chunk.GetComponent<Chunk>();
        chunks.Add(chunk);
        newChunk.Init(this, scoreManager);
        _spawnedChunkAmount++;
    }

    float CalculateSpawnPositionZ()
    {
        float spawnPosZ = 0f;
        if (chunks.Count == 0)
        {
            spawnPosZ = transform.position.z;
        }
        else
        {
            spawnPosZ = chunks[chunks.Count - 1].transform.position.z + chunkLength;
        }

        return spawnPosZ;
    }
}