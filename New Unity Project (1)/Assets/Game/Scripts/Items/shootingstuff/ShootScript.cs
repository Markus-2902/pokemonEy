using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    Transform playergun;
    Transform shootingpoint;
    GameObject player;
    Quaternion playerrotation;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playergun = player.transform.GetChild(0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        shootingpoint = player.transform.Find("ShootingPoint");
        if (Input.GetKeyDown(KeyCode.J) && ItemBehaviorScript.shoot==true)
        {
            
            Instantiate(bulletPrefab, shootingPoint.position, shootingpoint.rotation);
            ItemBehaviorScript.shoot = false;
            ItemBehaviorScript.activeitem = null;
            playergun.gameObject.SetActive(false);
            shootingpoint.gameObject.SetActive(false);
        }
    }
}
