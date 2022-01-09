using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogTriggerScript : MonoBehaviour
{
    public Rect r;
    public string text;
    public float x = 100;
    public float y = 0;
    public float w = 10;
    public float h = 10;
    public GUIStyle style = new GUIStyle();
    public GameObject dialogbackgroundimage;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }


    private void OnGUI()
    {
        GUI.Label(r, text);

    }
    // Update is called once per frame
    void Update()
    {
        GameObject cam = GameObject.Find("DynamicMainCam");
        r = new Rect(x, y, w, h);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{player.transform.position.x}, {player.transform.position.y}");
    }
    public void whichcam()
    {
        
    }
}