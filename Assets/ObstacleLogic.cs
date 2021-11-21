using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLogic : MonoBehaviour
{
    bool rewarded = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.5f, -2f),0);
        rewarded = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPlaying)
        {
            transform.position = transform.position + new Vector3(-GameManager.obstacleVelocity * Time.deltaTime, 0, 0);
            if (!rewarded && transform.position.x < 0){
                GameManager.score++;
                rewarded = true;
                //Debug.Log("we hit obstacle1 ");
                //Debug.Log("we hit obstacle2 ");
            }
            if (transform.position.x < -3)
            {
                transform.position = new Vector3(3, Random.Range(-0.5f, -2f), 0);
            }
        }

        
    }
}
