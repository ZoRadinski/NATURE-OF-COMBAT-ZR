using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;
    void Awake(){instance = this;}




    public List<GameObject> prefabs;
    public List<Transform> spawnPoints;

    float spawnInterval = 5f;
    float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if the timer has reached 20 seconds
        if (timer >= 10.0f)
        {
            // Decrease the spawn interval by 0.5
            spawnInterval -= 0.5f;

            // Reset the timer
            timer = 0.0f;
        }
    }

    public void StartSpawning()
    {
        StartCoroutine(SpawnDelay());

    }

    IEnumerator SpawnDelay()
    {
        SpawnEnemy();

        yield return new WaitForSeconds(spawnInterval);
        StartCoroutine(SpawnDelay());

    }

    void SpawnEnemy()
    {
        int randomPrefabID = Random.Range(0,prefabs.Count);
        int randomSpawnPointID = Random.Range(0,spawnPoints.Count);
        GameObject spawnedEnemy = Instantiate(prefabs[randomPrefabID],spawnPoints[randomSpawnPointID]);



    }




}
