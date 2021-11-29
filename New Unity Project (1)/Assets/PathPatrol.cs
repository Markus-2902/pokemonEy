using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPatrol : MonoBehaviour
{
    public Rigidbody2D enemyrb;

    public float movementspeed = 1f;

    public bool turn;

    string direction = "right";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (direction=="right")
        {
            enemyrb.velocity = new Vector2((movementspeed + Time.deltaTime), enemyrb.velocity.y);
        }
        else if (direction=="left")
        {
            enemyrb.velocity = new Vector2(((movementspeed + Time.deltaTime)*-1), enemyrb.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name=="fliptrigger")
        {
            Flip();
            Debug.Log("Flip!");
        }
        else
        {
            Debug.Log("No Flip");
        }
    }

    void Flip()
    {
        if (direction=="right")
        {
            direction = "left";
            Debug.Log("direction change to left");
        }
        else if (direction=="left")
        {
            direction = "right";
            Debug.Log("direction change to right");
        }
        else
        {
            Debug.LogError("Error");
        }
    }
}
