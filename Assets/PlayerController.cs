using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerBody;
    public float forceValue = 100f; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.isPlaying && Input.GetMouseButtonDown(0))
        {
            playerBody.AddForce(Vector3.up * forceValue);
        }
        if(transform.position.y>1.25f || transform.position.y < -1.25f)
        {
            GameManager.isPlaying = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.isPlaying = false;
    }
}
