using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class camchangetriggerscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dyncam;
    public GameObject statcam;
    public float[] statcamcords = { 0 };
    int cordindex=1;
    Vector3 statcamcordwithnewx;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            statcamcordwithnewx = new Vector3(statcamcords[cordindex], statcam.transform.position.y, -10);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CamTrigger")
        {
            if (dyncam.activeSelf==true && statcam.activeSelf==false)
            {
                dyncam.SetActive(false);
                statcam.SetActive(true);
                statcam.transform.position = statcamcordwithnewx;
                cordindex++;
                Debug.Log("wurde statisch");
            }
            else if (dyncam.activeSelf==false && statcam.activeSelf==true)
            {
                dyncam.SetActive(true);
                statcam.SetActive(false);
                Debug.Log("wurde dynamisch");
            }
            else
            {
                Debug.LogError("Oida beide cams sind entweder on oder off");
            }

        }
    }
}
