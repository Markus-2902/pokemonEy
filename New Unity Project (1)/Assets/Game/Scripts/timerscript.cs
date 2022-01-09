using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    public static double timer = 0.0f;
    public static double seconds;
    int last;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("lolstart");
    }
    // Update is called once per frame
    void Update()
    {
        MyTimer();
    }

    void MyTimer()
    {
        timer += Time.deltaTime;
        seconds = Math.Floor(timer);
        if (last != Convert.ToInt32(seconds))
        {

            last = Convert.ToInt32(seconds);
            Debug.Log(seconds);
        }
        else if ((last != Convert.ToInt32(seconds)) && (seconds == Math.Floor(0.0)))
        {
            last = Convert.ToInt32(seconds);
            Debug.Log(seconds);
        }
    }

    
}