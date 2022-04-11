using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.MLAgents;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public static GameManager Instance;
    private StatsRecorder statsRecorder;

    //public static bool isPlaying = true;
    public static float obstacleVelocity = 0.4f;
    public static float bgVelocity = 0.1f; //0.01f
    //public static int score = 0;
    private int highScore = 0;

    /*
    private void Update()
    {
        //obstacleVelocity += 0.02f * Time.deltaTime;
        //bgVelocity += 0.005f * Time.deltaTime;
        scoreText.text = "" + score;

    }*/

    private void Awake()
    {
        Instance = this;
        statsRecorder = Academy.Instance.StatsRecorder;
    }
    public void AddScore(int score)
    {
        if (score > highScore)
            
            {
            Debug.Log(score + "," + highScore);
            highScore = score;
            scoreText.text = score.ToString();
            statsRecorder.Add("High Score", highScore, StatAggregationMethod.MostRecent);
        }
        

    }

}
