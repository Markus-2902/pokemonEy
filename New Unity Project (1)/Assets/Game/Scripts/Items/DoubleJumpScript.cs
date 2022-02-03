using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpScript : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void doublejumpfunc()
    {
        if (Input.GetKeyDown(KeyCode.J) && ItemBehaviorScript.activeitem != null)
        {
            if ((Movmentment2DCharacter._rigidbody.transform.position.y) <= ((Movmentment2DCharacter._rigidbody.transform.position.y) + (Movmentment2DCharacter.JumpForce)))
            {
                Movmentment2DCharacter._rigidbody.AddForce(new Vector2(0, Movmentment2DCharacter.JumpForce), ForceMode2D.Impulse);
            }
        }
    }
}
