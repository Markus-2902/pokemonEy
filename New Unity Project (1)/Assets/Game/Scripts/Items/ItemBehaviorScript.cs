using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemBehaviorScript : MonoBehaviour
{
    public static bool doublejumpisup = false;
    GameObject player;
    public static GameObject activeitem = null;
    GameObject olditem;

    public static bool shoot = false;
    Transform playergun;
    Transform shootingpoint;
    Transform playerarm;
    public static bool dothrow = false;

    public static bool hook = false;

    public static List<GameObject> catchedpokemon;
    // Start is called before the first frame update
    void Start()
    {
        activeitem = SaveVarsAcreossScenesScript.activeitem;
        player = GameObject.FindGameObjectWithTag("Player");
        catchedpokemon = new List<GameObject>();

        playergun = player.transform.GetChild(0);
        shootingpoint = player.transform.GetChild(1);
        playerarm = player.transform.GetChild(2);
        playerarm.gameObject.SetActive(false);
        playergun.gameObject.SetActive(false);
        shootingpoint.gameObject.SetActive(false);
    }

    private void OnGUI()
    {
        if (activeitem!=null)
        {
            GUI.Label(new Rect(-100, 20, 200, 40), activeitem.name);
        }
    }

    /*public void placeold()
    {
        olditem.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2F);
        olditem.SetActive(true);
        olditem = GameObject.Instantiate(activeitem);
        olditem.name = activeitem.name;
        olditem.SetActive(false);
    }*/

    private void OnTriggerEnter2D(Collider2D newitemcol)
    {
        if (activeitem==null && newitemcol.tag=="Item")
        {
            activeitem=GameObject.Instantiate(newitemcol.gameObject);
            activeitem.name = newitemcol.name;
            activeitem.SetActive(false);
            Destroy(newitemcol.gameObject);
        }



        /*if (activeitem==null && newitemcol.gameObject.tag=="Item")
        {
            activeitem = GameObject.Instantiate(newitemcol.gameObject);
            activeitem.name = newitemcol.name;
            activeitem.SetActive(false);
            Destroy(newitemcol.gameObject);
            Debug.Log($"active item: {activeitem.name}");

        }
        else if (activeitem!=null && newitemcol.gameObject.tag=="Item")
        {
            placeold();
            activeitem = GameObject.Instantiate(newitemcol.gameObject);
            activeitem.name = newitemcol.name;
            activeitem.SetActive(false);
            Destroy(newitemcol.gameObject);
            Debug.Log($"active item: {activeitem.name} old: {olditem.name}");
        }
        else
        {
            Debug.LogError($"ERROR: active Item:{activeitem.name}, old Item:{olditem.name}");
        }*/









        /*if (activeitem==null && collision.tag=="Items")
        {
            activeitem = GameObject.Instantiate(collision.gameObject);
            activeitem.name = collision.name;
            activeitem.SetActive(false);
            Destroy(collision.gameObject);
        }
        else if (activeitem!=null && collision.tag=="Items")
        {
            placeitem = activeitem;
            activeitem = GameObject.Instantiate(collision.gameObject);
            activeitem.name = collision.name;
            Destroy(collision.gameObject);
        }*/
        /*string name;
        if (collision.tag=="Item")
        {
            if (activeitem==null && placeitem==null)
            {
                activeitem = collision.gameObject;
                Destroy(collision.gameObject);
            }
            else if (activeitem == null && placeitem != null)
            {
                //item genutzt
                activeitem = collision.gameObject;
                Destroy(collision.gameObject);
                placeitem.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2F);
                placeitem.SetActive(true);

            }
            else if (activeitem != null && placeitem == null)
            {
                placeitem = GameObject.Instantiate(activeitem);
                activeitem = collision.gameObject;
                Destroy(collision.gameObject);
            }
            else if (activeitem != null & placeitem != null)
            {
                placeitem = GameObject.Instantiate(activeitem);
                activeitem = i
            }
        }*/


    }
    // Update is called once per frame
    void Update()
    {
        if (activeitem!=null)
        {
            
            Debug.Log(activeitem.name);
            useitem();
        }
        //Debug.Log($"doublejumpup:{doublejumpisup}");


    }


    public void useitem()
    {
        if (activeitem.name=="Item_DoubleJump")
        {
            //implemented in Movementscript
            
            
        }
        else if (activeitem.name=="Item_GrapplingHook")
        {
            
        }
        else if (activeitem.name == "Item_Pokeball")
        {
            playerarm.gameObject.SetActive(true);
            shootingpoint.gameObject.SetActive(true);
            dothrow = true;
        }
        else if (activeitem.name == "Item_Pokegun")
        {
            playergun.gameObject.SetActive(true);
            shootingpoint.gameObject.SetActive(true);
            shoot = true;
            
        }
        else
        {

        }
    }
}
