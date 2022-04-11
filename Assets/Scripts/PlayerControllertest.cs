using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;


public class PlayerControllertest : Agent
{
    Rigidbody2D playerBody;
    public float forceValue = 0f; //was 100f //initial gravity .2f
    private int score = 0;
    public event Action OnReset;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    /*
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        
    }*/

    public override void Initialize()
    {
        playerBody = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        if (Mathf.FloorToInt(vectorAction[0]) == 1)
        {
            playerBody.AddForce(Vector3.up * .2f);         //during training it was 0.1f
            Debug.Log(" vectoraction " + vectorAction[0]);
        }
        else
        {
            Debug.Log("not vectoraction " + vectorAction[0]);
        }
    }

    public override void OnEpisodeBegin()
    {
        Reset();
    }
    /*
    private void FixedUpdate()
    {

        if (transform.position.y > 1.5f || transform.position.y < -1.5f)   //initial limit was 1.25f
        {
            //GameManager.isPlaying = false;
            AddReward(-1.0f);
            EndEpisode();
            //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        
        RequestDecision();
    }*/

    public override void Heuristic(float[] actionsOut)
    {
        actionsOut[0] = 0;
        if (Input.GetMouseButtonDown(0))
        {
            actionsOut[0] = 1;
            Debug.Log("inside heuristic " + actionsOut[0]);
        }

    }

    private void Reset()
    {
        score = 0;
        //jumpIsReady = true;

        //Reset Movement and Position
        transform.position = startingPosition;
        playerBody.velocity = Vector3.zero;

        OnReset?.Invoke();
    }

    // Update is called once per frame
    
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            playerBody.AddForce(Vector3.up * 10f);
        }
        if(transform.position.y>1.25f || transform.position.y < -1.25f)
        {
            //GameManager.isPlaying = false;

            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (transform.position.x < -3.0f )
        {
            //GameManager.isPlaying = false;

            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("scoring"))
        {
            score++;
            AddReward(0.5f);      //earlier it was 0.1f
            //Debug.Log("current score" + score);
            //Debug.Log("+ve reward" + GetCumulativeReward());
            GameManager.Instance.AddScore(score);
        }

        if (other.gameObject.CompareTag("obstacle"))
        {
            AddReward(-1.0f);

            //Debug.Log("hit wall");


        }


    }


    /*

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddReward(-1.0f);
        //Debug.Log("-ve reward" + GetCumulativeReward());

        //EndEpisode();

        //GameManager.isPlaying = false;
        //playerBody.velocity = new Vector3(0, 0, 0);
        //GameManager.isPlaying = true;
    }*/

}
