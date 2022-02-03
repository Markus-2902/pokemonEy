using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialTriggerScriptOld : MonoBehaviour
{
    string text;
    public GameObject staticCam;
    public GameObject dynamicCam;
    GameObject statictextobj;
    GameObject dynamictextobj;
    GameObject staticturnobj;
    GameObject dynamicturnobj;
    public List<string> easytexts;
    public List<string> realistictexts;
    //bool activedialog = false;
    int textind = 0;
    bool firstentered;
    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        if (test == true)
        {
            RememberNUseDifScript.currentactive = 0;
        }
        staticturnobj = staticCam.transform.Find("DialogBackground").gameObject;
        dynamicturnobj = dynamicCam.transform.Find("DialogBackground").gameObject;
        firstentered = false;
        statictextobj = staticturnobj.transform.Find("StatCanvas").gameObject.transform.Find("StatText").gameObject;
        dynamictextobj = dynamicturnobj.transform.Find("DynCanvas").gameObject.transform.Find("DynText").gameObject;

        staticturnobj.SetActive(false);
        dynamicturnobj.SetActive(false);
        
        Debug.Log($"static:{staticCam.tag}, dynamic:{dynamicCam.tag}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && firstentered==true)
        {
            textind++;
            if (RememberNUseDifScript.currentactive == 0)
            {
                if (textind<=easytexts.Count)
                {
                    if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                    {
                        statictextobj.GetComponent<Text>().text = easytexts[textind];
                    }
                    else if (staticCam.activeSelf == false && dynamicCam.activeSelf == false)
                    {
                        dynamictextobj.GetComponent<Text>().text = easytexts[textind];
                    }
                }
                else if (textind>easytexts.Count)
                {

                }
            }
            else if (RememberNUseDifScript.currentactive == (SwitchDifSelectionScript.whichactive)2)
            {
                if (textind <= realistictexts.Count)
                {
                    if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                    {
                        staticturnobj.SetActive(true);
                        statictextobj.GetComponent<Text>().text = realistictexts[textind];
                        firstentered = true;
                    }
                    else if (staticCam.activeSelf == false && dynamicCam.activeSelf == false)
                    {
                        dynamictextobj.SetActive(true);
                        dynamictextobj.GetComponent<Text>().text = realistictexts[textind];
                        firstentered = true;
                    }
                }
                else if (textind>realistictexts.Count)
                {
                    if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                    {
                        staticturnobj.SetActive(false);
                    }
                    else if (staticCam.activeSelf == false && dynamicCam.activeSelf == false)
                    {
                        dynamictextobj.SetActive(false);
                    }
                }
            }
        }
    }

        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name=="Player")
        {
            Debug.LogWarning("PlayerTrue");
            if (firstentered==false)
            {
                Debug.LogWarning("firstentered was false");
                /*if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                {
                    staticturnobj.SetActive(true);
                    DialogUseage(statictextobj, staticturnobj);
                    activedialog = true;
                    firstenter = true;
                }
                else if (staticCam.activeSelf == false && dynamicCam.activeSelf == true)
                {
                    dynamicturnobj.SetActive(true);
                    DialogUseage(dynamictextobj, dynamicturnobj);
                    activedialog = true;
                    firstenter = true;
                }*/
                if (RememberNUseDifScript.currentactive== (SwitchDifSelectionScript.whichactive)0)
                {
                    Debug.LogWarning("easy");
                    if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                    {
                        Debug.LogWarning("stat cam");
                        staticturnobj.SetActive(true);
                        statictextobj.GetComponent<Text>().text = easytexts[textind];
                        firstentered = true;
                    }
                    else if (staticCam.activeSelf == false && dynamicCam.activeSelf == false)
                    {
                        Debug.LogWarning("dyn cam");
                        dynamicturnobj.SetActive(true);
                        dynamictextobj.GetComponent<Text>().text = easytexts[textind];
                        firstentered = true;
                    }
                }
                else if (RememberNUseDifScript.currentactive == (SwitchDifSelectionScript.whichactive)2)
                {
                    Debug.LogWarning("realistic");
                    if (staticCam.activeSelf == true && dynamicCam.activeSelf == false)
                    {
                        staticturnobj.SetActive(true);
                        statictextobj.GetComponent<Text>().text = realistictexts[textind];
                        firstentered = true;
                    }
                    else if (staticCam.activeSelf == false && dynamicCam.activeSelf == false)
                    {
                        dynamictextobj.SetActive(true);
                        dynamictextobj.GetComponent<Text>().text = realistictexts[textind];
                        firstentered = true;
                    }
                }
            }
        }

    }

    

    public void DialogUseage(GameObject tex, GameObject tur)
    {
        /*if (RememberNUseDifScript.currentactive==(SwitchDifSelectionScript.whichactive)0 || RememberNUseDifScript.currentactive==(SwitchDifSelectionScript.whichactive)1)
        {
            if (textind <= easytexts.Count-1)
            {
                tex.GetComponent<Text>().text = easytexts[textind];
                textind++;
            }
            else if (textind>easytexts.Count-1)
            {
                tur.SetActive(false);
                activedialog = false;
            }
        }
        else if (RememberNUseDifScript.currentactive == (SwitchDifSelectionScript.whichactive)2)
        {
            if (textind <= easytexts.Count - 1)
            {
                tex.GetComponent<Text>().text = realistictexts[textind];
                textind++;
            }
            else if (textind > easytexts.Count - 1)
            {
                tur.SetActive(false);
                activedialog = false;
            }
        }*/



    }
}