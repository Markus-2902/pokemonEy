using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmentment2DCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 10;
    public static float JumpForce = 5;
    //bool nojumpafterjump = false;
    public static Rigidbody2D _rigidbody;
    public static bool? shootingdirection = null;
    Transform playergun;
    Transform shootingpoint;
    Transform playerarm;
    GameObject player;
    public bool moveable = true;
    Animator anim;
    Vector2 v2 = new Vector2(0.01F, 0);
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        try
        {
            playergun = player.transform.Find("PlayerGun");
            shootingpoint = player.transform.Find("ShootingPoint");
            playerarm = player.transform.Find("PlayerArm");
        }
        catch (System.Exception)
        {

            Debug.LogError("ok");
        }
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {

        if (moveable == true)
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            var movement = Input.GetAxis("Horizontal");
            Vector3 movement_vector = new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
            transform.position += movement_vector;


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                anim.enabled = true;
            }
            else
            {
                anim.enabled = false;
            }

            try
            {
                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    //playergun.transform.position = new Vector3(player.transform.position.x - 0.46F, player.transform.position.y);
                    //shootingpoint.transform.position = new Vector3(player.transform.position.x - 0.96F, player.transform.position.y);
                    //playerarm.transform.position = playergun.transform.position;
                    player.transform.rotation = new Quaternion(0, 180, 0, 0);
                    shootingdirection = true;
                    
                }
                else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    //playergun.transform.position = new Vector3(player.transform.position.x + 0.46F, player.transform.position.y);
                    //shootingpoint.transform.position = new Vector3(player.transform.position.x + 0.96F, player.transform.position.y);
                    //playerarm.transform.position = playergun.transform.position;
                    player.transform.rotation = new Quaternion(0, 0, 0, 0);
                    shootingdirection = false;
                }
            }
            catch (System.Exception)
            {

                //Debug.LogError("okay2");
            }
            Jump();
        }
        else
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }

    public void Jump()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Mathf.Abs(_rigidbody.velocity.y) < 0.001f && ItemBehaviorScript.doublejumpisup==false)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
            else if (ItemBehaviorScript.activeitem!=null)
            {
                if (ItemBehaviorScript.activeitem.name == "Item_DoubleJump" && ItemBehaviorScript.doublejumpisup == true)
                {
                    _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                    ItemBehaviorScript.doublejumpisup = false;
                }
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currenthight = _rigidbody.transform.position.y;
            if (Mathf.Abs(_rigidbody.velocity.y)<0.001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                if (ItemBehaviorScript.activeitem.name=="Item_DoubleJump" && ItemBehaviorScript.activeitem!=null)
                {
                    ItemBehaviorScript.doublejumpisup = true;
                }
            }
            //Mathf.Abs(_rigidbody.velocity.y) > 0.1f && 
            /*else if (ItemBehaviorScript.doublejumpisup == true && !(Mathf.Abs(_rigidbody.velocity.y) < 0.001f) && ((_rigidbody.transform.position.y)>=(_rigidbody.transform.position.y+(JumpForce))))
            {
                ItemBehaviorScript.doublejumpisup = false;
                nojumpafterjump = true;
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                Destroy(ItemBehaviorScript.activeitem);
            }*/
            else if (ItemBehaviorScript.doublejumpisup == true)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                ItemBehaviorScript.doublejumpisup = false;
                ItemBehaviorScript.activeitem = null;
            }
        }
    }
}
