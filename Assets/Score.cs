using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float timeBetweenWaves = 1.15f;

    private float timeToSpawn = 3.65f;
    public Text scoreText;
    public static int score;
    private float time;
    
    void Start(){
        score = 0;
    }

    void Update(){

        time = Time.timeSinceLevelLoad;

        if (time >= timeToSpawn){
            score += 1;
            scoreText.text = score.ToString();
            timeToSpawn = time + timeBetweenWaves;
            if (timeBetweenWaves >= 0.6f){
                timeBetweenWaves -= 0.005f;
            }
        }
    }
}  