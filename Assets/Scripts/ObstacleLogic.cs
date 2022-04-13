using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLogic : MonoBehaviour
{
    bool rewarded = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-1.4f, -1.0f), transform.position.z);
        //transform.position = new Vector3(transform.position.x, -1.2f, transform.position.z);
        rewarded = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("inside update");



        //if (GameManager.isPlaying)
        //{
            transform.position = transform.position + new Vector3(-GameManager.obstacleVelocity * Time.deltaTime, 0, 0);
            /*if (!rewarded && transform.position.x < 0){
                GameManager.score++;
                rewarded = true;
                Debug.Log("current score"+ GameManager.score);
                //Debug.Log("we hit obstacle2 ");
            }*/
            if (transform.position.x < -3)
            {
                transform.position = new Vector3(3, Random.Range(-1.5f, -0.9f), transform.position.z);
                //transform.position = new Vector3(3, -1.2f, transform.position.z);
            }
        //}

        
    }
}
