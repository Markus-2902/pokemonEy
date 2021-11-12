using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    public int othercount = 0;
    public int timecount = 0000;
    int ticknum = 10000000;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        othercount++;
        if (othercount % ticknum == 0)
        {
            timecount++;
            Console.WriteLine(timecount);
        }
    }

    void MyTimer()
    {
        
    }
}