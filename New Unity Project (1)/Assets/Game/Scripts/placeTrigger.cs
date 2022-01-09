using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTrigger : MonoBehaviour
{
    public GameObject groundgo;
    public Rigidbody2D rbtrigger;
    public GameObject thisobj;
    public bool posisleft;
    
    // Start is called before the first frame update
    void Start()
    {        
        float leftposfltrig = ((groundgo.transform.localScale.x / 2.0f)+(thisobj.transform.localScale.x/2))*-1f;
        float rightposfltrig = ((groundgo.transform.localScale.x / 2.0f)+ (thisobj.transform.localScale.x / 2));
        if (posisleft==true)
        {
            rbtrigger.transform.position = new Vector2(leftposfltrig, rbtrigger.position.y);
            Debug.Log("Pos left");
        }
        else if (posisleft==false)
        {
            rbtrigger.transform.position = new Vector2(rightposfltrig, rbtrigger.position.y);
            Debug.Log("Pos right");
        }
        else
        {
            Debug.Log("Doesn't work");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
