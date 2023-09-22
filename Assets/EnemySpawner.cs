using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float enemyRate = 5;
    private float nextEnemy = 1;

    // Number of enemies to spawn at a time
    public int enemiesPerSpawn = 3;

    // Define the boundaries for the fixed spawn area
    private float minX = -10f;
    private float maxX = 10f;
    private float minY = 7f;
    private float maxY = 7f;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
        if (nextEnemy <= 0)
        {
            nextEnemy = enemyRate;
            
            // Spawn multiple enemies based on enemiesPerSpawn
            for (int i = 0; i < enemiesPerSpawn; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
