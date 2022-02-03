using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightSkinButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (RememberSpriteScript.currentskinindex<RememberSpriteScript.skins.Count-1)
        {
            RememberSpriteScript.currentskinindex++;
        }
        else
        {
            RememberSpriteScript.currentskinindex = 0;
        }
    }
}
