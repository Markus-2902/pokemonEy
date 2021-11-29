using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    public bool mustPatrol;

    public Rigidbody2D rb;

    public float walkspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol==true)
        {
            Patrol();
            Debug.Log("if funktioniert");
            
        }
    }

    void Patrol()
    {
        rb.velocity = new Vector2(walkspeed * Time.deltaTime, rb.velocity.y);
        Debug.Log("patrol wird ausgeführt");
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkspeed *= -1;
        mustPatrol = true;
    }

}
