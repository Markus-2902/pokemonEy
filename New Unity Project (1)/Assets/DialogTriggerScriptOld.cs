using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerScriptOld : MonoBehaviour
{
    public GameObject groundforstatcam;
    public GameObject dymcam;
    public GameObject statcam;
    public bool dymdiaplacement;
    public string text = "testdialog";
    string? textfield;
    public Rect textfieldrec;
    bool? movetoplayer = null;
    bool firstcreate = true;
    double starttoshow;
    double howlong = 5;
    bool showedonce = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{this.GetType().Name} got called");
    }

    // Update is called once per frame
    void Update()
    {
        if (firstcreate)
        {
            if (movetoplayer == false)
            {
                textfieldrec = new Rect(groundforstatcam.transform.position.x, groundforstatcam.transform.position.y - 10, 200, 40);
                textfield = GUI.TextField(textfieldrec, text);
                onceondebug("movetoplayer false");
            }
            else if (movetoplayer == true)
            {
                textfieldrec = new Rect(dymcam.transform.position.x, dymcam.transform.position.y - 10, 200, 40);
                textfield = GUI.TextField(textfieldrec, text);
                onceondebug("movetoplayer true");
            }
            firstcreate = false;
        }
        else if (!firstcreate)
        {
            if (((timerscript.seconds)-starttoshow)>=howlong)
            {
                textfield = null;
            }
            else if (((timerscript.seconds)-starttoshow)<howlong)
            {
                if (movetoplayer == false)
                {
                    textfieldrec = new Rect(groundforstatcam.transform.position.x, groundforstatcam.transform.position.y - 10, 200, 40);
                    text = "mtp = false";
                    textfield = GUI.TextField(textfieldrec, text);
                    
                }
                else if (movetoplayer == true)
                {
                    text = "mtp = true";
                    textfieldrec = new Rect(dymcam.transform.position.x, dymcam.transform.position.y - 10, 200, 40);
                    textfield = GUI.TextField(textfieldrec, text);
                }
            }
        }   
    }

    private void OnGUI()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DialogTriggerObj" && dymdiaplacement==true)
        {
            movetoplayer = true;
            Debug.Log("Collision dym true");
        }
        if (collision.tag == "DialogTriggerObj" && dymdiaplacement == false)
        {
            movetoplayer = false;
            Debug.Log("Collision dym false");
        }
        starttoshow = timerscript.seconds;
    }

    public void onceondebug(string x)
    {
        if (showedonce == false)
        {
            Debug.Log(x);
        }
    }
}