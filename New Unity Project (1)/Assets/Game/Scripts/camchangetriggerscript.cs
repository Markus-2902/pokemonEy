using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camchangetriggerscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dyncam;
    public GameObject statcam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (dyncam.activeSelf==true && statcam.activeSelf==false)
            {
                dyncam.SetActive(false);
                statcam.SetActive(true);
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
