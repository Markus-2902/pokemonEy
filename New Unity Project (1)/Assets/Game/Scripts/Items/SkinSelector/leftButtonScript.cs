using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftButtonScript : MonoBehaviour
{
    public GameObject player;
    List<Color> colors;
    public static int generalColorindex;
    // Start is called before the first frame update
    void Start()
    {
        generalColorindex = 0;
        colors = new List<Color>() { Color.blue, Color.red, Color.yellow };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(generalColorindex);
            if (generalColorindex < 0)
            {
                generalColorindex = colors.Count;
            }
            else if (generalColorindex > 0)
            {
                
                player.GetComponent<SpriteRenderer>().color = colors[generalColorindex];
                generalColorindex--;
            }
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("mouseclicked");
        if (generalColorindex==0)
        {
            generalColorindex = colors.Count;
        }
        else if (generalColorindex>0)
        {
            generalColorindex -= 1;
            player.GetComponent<SpriteRenderer>().color = colors[generalColorindex];
        }
    }

    public void left()
    {
        Debug.Log("mouseclicked");
        if (generalColorindex == 0)
        {
            generalColorindex = colors.Count;
        }
        else if (generalColorindex > 0)
        {
            generalColorindex -= 1;
            player.GetComponent<SpriteRenderer>().color = colors[generalColorindex];
        }
    }
}
