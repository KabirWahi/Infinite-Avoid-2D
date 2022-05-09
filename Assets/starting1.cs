using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starting1 : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab1;
    public GameObject blockPrefab2;
    private float timeToSpawn = 3f;
    // Start is called before the first frame update
    private float time;
    
    void Update(){
        time = Time.timeSinceLevelLoad;

        if (time >= timeToSpawn){
            SpawnBlocks();
            int randomIndex = Random.Range(1, 5);
            timeToSpawn = time + randomIndex;
        }

    
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        if (randomIndex == 0)
        {
            Instantiate(blockPrefab1, spawnPoints[0].position, Quaternion.identity);
        }
        else
        {
            Instantiate(blockPrefab2, spawnPoints[1].position, Quaternion.identity);
        }

}
}
