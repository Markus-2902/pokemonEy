using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SwitchDifSelectionScript : MonoBehaviour
{
    public enum whichactive { 
        easy = 0,
        medium = 1,
        realistic = 2
    };
    static GameObject[] difs;
    static GameObject[] descs;
    static Vector3 activescale = new Vector3(0.8F, 0.8F);
    static Vector3 inactivescale = new Vector3(0.6F, 0.6F);
    static Color activecolor = new Color(1F, 1F, 1F, 1F);
    static Color inactivecolor = new Color(1F, 1F, 1F, 0.5333334F);
    static Color inactivcolor2 = new Color(1F, 1F, 1F, 0.0F);
    public static int n;
    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        difs = GameObject.FindGameObjectsWithTag("dif");
        descs = GameObject.FindGameObjectsWithTag("desc");
        foreach (GameObject item in descs)
        {
            if (item.name.Contains("Medium")||item.name.Contains("Realistic"))
            {
                item.GetComponent<SpriteRenderer>().color = inactivcolor2;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SwitchActive(this.gameObject);
        
    }

    public static void SwitchActive(GameObject go)
    {
        
        foreach (GameObject item in difs)
        {
            if (go == item)
            {
                foreach (GameObject i in descs)
                {
                    if (i.name.Contains(go.name.Substring(0, go.name.Length - 3))==true)
                    {
                        i.GetComponent<SpriteRenderer>().color = activecolor;
                    }
                    else
                    {
                        i.GetComponent<SpriteRenderer>().color = inactivcolor2;
                    }
                    Debug.Log(i.name.Contains(go.name.Substring(0, go.name.Length - 3)));
                }
                Debug.LogWarning($"1: {go.name.Substring(0, go.name.Length - 3)}");
                Debug.LogWarning($"2: {go.name}");
                go.transform.localScale = activescale;
                go.GetComponent<SpriteRenderer>().color = activecolor;
                if (item.name=="EasyDif")
                {
                    n = 0;
                }
                else if (item.name == "MediumDif")
                {
                    n = 1;
                }
                else if (item.name == "RealisticDif")
                {
                    n = 2;
                }
                RememberNUseDifScript.currentactive = (whichactive)n;
                Debug.LogWarning($"{RememberNUseDifScript.currentactive}, {n}");
            }
            else
            {
                item.transform.localScale = inactivescale;
                item.GetComponent<SpriteRenderer>().color = inactivecolor;
            }
        }
    }
}