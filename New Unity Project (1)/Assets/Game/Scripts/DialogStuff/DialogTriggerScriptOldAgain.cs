using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogTriggerScript : MonoBehaviour
{
    public Rect r;
    public string text;
    public float x = 0;
    public float y = -2;
    public float w = 8;
    public float h = 4;
    public GameObject dialogbackgroundstat;
    public GameObject dialogbackgrounddyn;
    public GameObject staticCam;
    public GameObject dynamicCam;
    public GameObject player;

    public Transform StatCan;
    public Transform DynCan;
    public bool? dynorstat = null;
    // Start is called before the first frame update
    void Start()
    {

        r = new Rect(new Vector2(x, y), new Vector2(w, h));
        StatCan = staticCam.transform.GetChild(1);
        DynCan = dynamicCam.transform.GetChild(1);
    }


    private void OnGUI()
    {
        if (dynorstat==true)
        {
            
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (staticCam.activeSelf==true && dynamicCam.activeSelf==false)
        {
            dialogbackgroundstat.gameObject.SetActive(true);
            DynCan.gameObject.SetActive(true);
            
            dynorstat = false;
        }
        else if (staticCam.activeSelf==false && dynamicCam.activeSelf==true)
        {
            dialogbackgrounddyn.gameObject.SetActive(true);
            StatCan.gameObject.SetActive(true);
            
            dynorstat = true;
        }
    }
    public void whichcam()
    {
        
    }
}