using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float moveSpeed = 1f;

    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidbody.velocity = new Vector2((moveSpeed+ Time.deltaTime), 0f);
        }
        else
        {
            myRigidbody.velocity = new Vector2(-(moveSpeed+ Time.deltaTime), 0f);
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ft")
        {
            transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), transform.localScale.y);
        }
    }
}
