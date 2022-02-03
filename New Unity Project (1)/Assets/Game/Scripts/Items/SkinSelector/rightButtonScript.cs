using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightButtonScript : MonoBehaviour
{
    public GameObject player;
    List<Color> colors;
    // Start is called before the first frame update
    void Start()
    {
        colors = new List<Color>() { Color.blue, Color.red, Color.yellow };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log(leftButtonScript.generalColorindex);
            if (leftButtonScript.generalColorindex >= colors.Count)
            {
                leftButtonScript.generalColorindex = 0;
            }
            else if (leftButtonScript.generalColorindex < colors.Count)
            {
                
                player.GetComponent<SpriteRenderer>().color = colors[leftButtonScript.generalColorindex];
                leftButtonScript.generalColorindex++;
            }
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("mouseclicked");
        if (leftButtonScript.generalColorindex >= colors.Count)
        {
            leftButtonScript.generalColorindex = 0;
        }
        else if (leftButtonScript.generalColorindex < colors.Count)
        {
            leftButtonScript.generalColorindex += 1;
            player.GetComponent<SpriteRenderer>().color = colors[leftButtonScript.generalColorindex];
        }
    }

    public void right()
    {
        Debug.Log("mouseclicked");
        if (leftButtonScript.generalColorindex >= colors.Count)
        {
            leftButtonScript.generalColorindex = 0;
        }
        else if (leftButtonScript.generalColorindex < colors.Count)
        {
            leftButtonScript.generalColorindex += 1;
            player.GetComponent<SpriteRenderer>().color = colors[leftButtonScript.generalColorindex];
        }
    }
}
