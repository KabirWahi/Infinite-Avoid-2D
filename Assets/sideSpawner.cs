using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab1;
    public GameObject blockPrefab2;
    private float timeToSpawn = 30f;
    // Start is called before the first frame update
    private float time;
    public float timeBetweenWaves = 5f;
    
    void Update(){
        time = Time.timeSinceLevelLoad;

        if (time >= timeToSpawn){
            SpawnBlocks();
            int randomIndex = Random.Range(1, 5);
            timeToSpawn = time + timeBetweenWaves + randomIndex;
            if (timeBetweenWaves >= 0f){
                timeBetweenWaves -= 0.2f;
            }
        }

    
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        if (randomIndex == 0)
        {
            Instantiate(blockPrefab1, spawnPoints[0].position, Quaternion.identity);
        }
        else if(randomIndex == 1)
        {
            Instantiate(blockPrefab1, spawnPoints[1].position, Quaternion.identity);
        }
        else if(randomIndex == 2)
        {
            Instantiate(blockPrefab2, spawnPoints[2].position, Quaternion.identity);
        }
        else
        {
            Instantiate(blockPrefab2, spawnPoints[3].position, Quaternion.identity);
        }

}
}
