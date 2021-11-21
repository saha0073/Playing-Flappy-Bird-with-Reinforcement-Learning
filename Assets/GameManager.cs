using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public static bool isPlaying = true;
    public static float obstacleVelocity = 0.2f;
    public static float bgVelocity = 0.1f; //0.01f
    public static int score = 0;

    private void Update()
    {
        obstacleVelocity += 0.02f * Time.deltaTime;
        bgVelocity += 0.005f * Time.deltaTime;
        scoreText.text = "" + score;

    }

}
