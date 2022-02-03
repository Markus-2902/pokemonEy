using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPatrol : MonoBehaviour
{
    public Rigidbody2D enemyrb;

    public GameObject enemy;

    public float movementspeed = 1f;

    public bool turn;

    public bool flies;

    float directionn;

    float leftorright = 1;

    //true == right, false == left
    public bool direction = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        /*Debug.LogError(direction);
        if (flies == false)
        {
            enemyrb.constraints = RigidbodyConstraints2D.None;
            if (direction == "right")
            {
                enemyrb.velocity = new Vector2((movementspeed + Time.deltaTime), enemyrb.velocity.y);
                Debug.LogWarning($"R:{enemyrb.velocity}");
            }
            else if (direction == "left")
            {
                enemyrb.velocity = new Vector2(((movementspeed + Time.deltaTime) * -1), enemyrb.velocity.y);
                Debug.LogWarning($"L:{enemyrb.velocity}");
            }
        }
        
        else if (flies == true)
        {
            enemyrb.constraints = RigidbodyConstraints2D.FreezePositionY;
            if (direction == "right")
            {
                enemyrb.velocity = new Vector2((movementspeed + Time.deltaTime), enemyrb.velocity.y);
                Debug.LogWarning($"R:{enemyrb.velocity}");
            }
            else if (direction == "left")
            {
                enemyrb.velocity = new Vector2(((movementspeed + Time.deltaTime) * -1), enemyrb.velocity.y);
                Debug.LogWarning($"L:{enemyrb.velocity}");
            }
        }
        enemyrb.constraints = RigidbodyConstraints2D.FreezeRotation;*/
        directionn = (movementspeed + Time.deltaTime) * leftorright;
        enemyrb.velocity = new Vector2(directionn, enemyrb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"TriggerEnter: {collision.name}: {direction}");
        if (collision.gameObject.name == "fliptrigger")
        {
            /*if (direction == "right")
            {
                direction = "left";
                Debug.LogWarning("direction change to left");
            }
            else if (direction == "left")
            {
                direction = "right";
                Debug.LogWarning("direction change to right");
            }
            else
            {
                Debug.LogError("Error");
            }*/
            if (leftorright == 1)
            {
                leftorright = -1;
            }
        }
        else
        {
            Debug.Log("No Flip");
        }
    }

    void Flip()
    {
        
    }
}
