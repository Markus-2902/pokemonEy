using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerscript : MonoBehaviour
{
    double timer = 0.0f;
    double seconds;
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
        seconds = Math.Floor(timer % 60);
        if (last != Convert.ToInt32(seconds))
        {
            last = Convert.ToInt32(seconds);
            Debug.Log(seconds);
        }
    }

    
}

public static class myfun
{
    public static bool IsBetween<T>(this T item, T start, T end)
    {
        return Comparer<T>.Default.Compare(item, start) >= 0
            && Comparer<T>.Default.Compare(item, end) <= 0;
    }
}