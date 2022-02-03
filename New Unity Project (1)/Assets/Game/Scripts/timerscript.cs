using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    public static double timer = 0.0;
    public static double seconds;
    int last;
    public bool running;
    // Start is called before the first frame update
    void Start()
    {
        timer = SaveVarsAcreossScenesScript.Timer;
        Debug.Log("lolstart");
    }
    // Update is called once per frame
    void Update()
    {
        MyTimer();
    }

    void MyTimer()
    {
        if (running == true)
        {
            timer += Time.deltaTime;
            seconds = Math.Floor(timer);
            if (last != Convert.ToInt32(seconds))
            {

                last = Convert.ToInt32(seconds);
                Debug.Log($"{seconds} seconds");
            }
            else if ((last != Convert.ToInt32(seconds)) && (seconds == Math.Floor(0.0)))
            {
                last = Convert.ToInt32(seconds);
                Debug.Log($"{seconds} seconds");
            }
        }
        else
        {

        }
    }

    
}