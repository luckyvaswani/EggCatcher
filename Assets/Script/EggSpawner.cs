using System;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab; // Prefab for the egg
    public float spawnInterval = 1f; // Time between spawns
    public float xRange = 8f; // Horizontal range for spawning

    void Start()
    {
        InvokeRepeating("SpawnEgg", 1f, spawnInterval); // Repeatedly call SpawnEgg
    }

    void SpawnEgg()
    {
        float randomX = UnityEngine.Random.Range(-xRange, xRange); // Random horizontal position
        Vector3 spawnPosition = new Vector3(randomX, 5f, 0); // Above the screen
        Instantiate(eggPrefab, spawnPosition, Quaternion.identity); // Spawn the egg
    }
}
