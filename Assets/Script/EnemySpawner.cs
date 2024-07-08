using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSpawn; // Array of objects to spawn randomly
    [SerializeField] private float minXPosition; // Minimum X position for spawning
    [SerializeField] private float maxXPosition; // Maximum X position for spawning
    [SerializeField] private float spawnInterval = 3.0f; // Spawn interval in seconds

    private void Start()
    {
        InvokeRepeating("SpawnRandomObject", 0f, spawnInterval); // Start spawning immediately and repeat every 3 seconds
    }

    private void SpawnRandomObject()
    {
        float randomXPosition = Random.Range(minXPosition, maxXPosition); // Generate a random X position within the range
        Vector3 spawnPosition = new Vector3(randomXPosition, transform.position.y, transform.position.z); // Set the spawn position
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], spawnPosition, Quaternion.identity); // Spawn a random object from the array
    }
}
