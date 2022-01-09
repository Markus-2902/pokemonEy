using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemBehaviorScript : MonoBehaviour
{
    float[] starthight;
    GameObject[] itemobjects;
    float richtung = 1;
    // Start is called before the first frame update
    void Start()
    {
        itemobjects = GameObject.FindGameObjectsWithTag("Items");
        for (int i = 0; i < itemobjects.Length; i++)
        {
            starthight[i] = itemobjects[i].transform.position.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        updownswitch(5);
        foreach (var item in itemobjects)
        {
            item.transform.position = new Vector3((item.transform.position.x*richtung), item.transform.position.y);
        }
    }

    public void updownswitch(int interval)
    {
        /*double currentseconds = timerscript.seconds;
        bool itsnot5 = true;
        while (itsnot5==true)
        {
            if (timerscript.seconds >= currentseconds+5)
            {
                richtung *= -1;
                break;
            }
        }
        Debug.Log("lol");*/
    }
}
