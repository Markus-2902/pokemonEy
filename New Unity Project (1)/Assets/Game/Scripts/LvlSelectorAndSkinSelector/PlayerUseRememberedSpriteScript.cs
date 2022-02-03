using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUseRememberedSpriteScript : MonoBehaviour
{
    Sprite sprite;
    public Sprite useablesprite;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<SpriteRenderer>().sprite = RememberSpriteScript.skins[RememberSpriteScript.currentskinindex];
        this.GetComponent<SpriteRenderer>().sprite = useablesprite;
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<SpriteRenderer>().sprite = RememberSpriteScript.skins[RememberSpriteScript.currentskinindex];
    }
}
