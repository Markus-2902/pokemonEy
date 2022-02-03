using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject ballPrefab;
    Transform playerarm;
    Transform shootingpoint;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerarm = player.transform.GetChild(2);
        shootingpoint = player.transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && ItemBehaviorScript.dothrow == true)
        {
            Instantiate(ballPrefab, shootingPoint.position, transform.rotation);
            ItemBehaviorScript.dothrow= false;
            ItemBehaviorScript.activeitem = null;
            playerarm.gameObject.SetActive(false);
            shootingpoint.gameObject.SetActive(false);
        }
    }
}
