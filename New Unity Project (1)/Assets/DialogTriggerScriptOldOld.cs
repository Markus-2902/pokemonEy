using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public GameObject groundforstatcam;
    public GameObject dymcam;
    public GameObject statcam;
    public bool dymdiaplacement;
    public string text = "testdialog";
    bool? movetoplayer = null;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnGUI()
    {
        if (movetoplayer == false)
        {
            GUI.Label(new Rect(dymcam.transform.position.x, dymcam.transform.position.y - 10, 200, 40), text);
            Debug.Log("movetoplayer false");

        }
        else if (movetoplayer == true)
        {
            GUI.Label(new Rect(dymcam.transform.position.x, dymcam.transform.position.y - 10, 200, 40), text);
            Debug.Log("movetoplayer false");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DialogTriggerObj" && dymdiaplacement == true)
        {
            movetoplayer = true;
            Debug.Log("Collision dym true");
        }
        if (collision.tag == "DialogTriggerObj" && dymdiaplacement == false)
        {
            movetoplayer = false;
            Debug.Log("Collision dym false");
        }
    }
}