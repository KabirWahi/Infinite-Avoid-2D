using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;
    // Start is called before the first frame update
    public float timeBetweenWaves = 1.15f;

    private float timeToSpawn = 1.5f;
    private float time;

    void Update(){
        time = Time.timeSinceLevelLoad;

        if (time >= timeToSpawn){
            SpawnBlocks();
            timeToSpawn = time + timeBetweenWaves;
            if (timeBetweenWaves >= 0.6f){
                timeBetweenWaves -= 0.005f;
            }
        }

    
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != randomIndex)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }

        }

}
}
