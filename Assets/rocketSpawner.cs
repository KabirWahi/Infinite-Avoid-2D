using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;
    // Start is called before the first frame update
    public float timeBetweenWaves = 10f;

    private float timeToSpawn = 53f;
    private float time;

    void Update(){
        time = Time.timeSinceLevelLoad;

        if (time >= timeToSpawn){
            SpawnBlocks();
            timeToSpawn = time + timeBetweenWaves;
        }

    
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i == randomIndex)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }

        }

}
}