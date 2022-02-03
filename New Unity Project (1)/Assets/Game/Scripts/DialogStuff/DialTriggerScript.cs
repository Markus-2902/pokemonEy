using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialTriggerScript : MonoBehaviour
{
    GameObject activecam;
    GameObject textobj;
    GameObject turnobj;
    public List<string> easytext;
    public List<string> realistictext;
    bool firstdone;
    SwitchDifSelectionScript.whichactive currentact;
    int index = 0;
    bool running;
    // Start is called before the first frame update
    void Start()
    {
        currentact = RememberNUseDifScript.currentactive;
        activecam = GameObject.FindGameObjectWithTag("MainCamera");
        turnobj = activecam.transform.Find("DialogBackground").gameObject;
        textobj = turnobj.transform.GetChild(0).GetChild(0).gameObject;

        turnobj.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)==true && running == true)
        {
            index++;
            if (firstdone == true)
            {
                if (currentact == 0)
                {
                    if (index <= easytext.Count-1)
                    {
                        turnobj.SetActive(true);
                        textobj.GetComponent<Text>().text = easytext[index];
                    }
                    else if (index > easytext.Count-1)
                    {
                        turnobj.SetActive(false);
                        running = false;
                        index = 0;
                        firstdone = false;
                    }
                }
                else if (currentact == (SwitchDifSelectionScript.whichactive)2)
                {
                    if (index <= realistictext.Count-1)
                    {
                        turnobj.SetActive(true);
                        textobj.GetComponent<Text>().text = realistictext[index];
                    }
                    else if (index > realistictext.Count-1)
                    {
                        turnobj.SetActive(false);
                        running = false;
                        index = 0;
                        firstdone = false;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (firstdone==false)
        {
            if (currentact == 0)
            {
                turnobj.SetActive(true);
                textobj.GetComponent<Text>().text = easytext[index];
                running = true;
                firstdone = true;
            }
            else if (currentact == (SwitchDifSelectionScript.whichactive)2)
            {
                turnobj.SetActive(true);
                textobj.GetComponent<Text>().text = realistictext[index];
                running = true;
                firstdone = true;
            }
            
        }
    }
}
