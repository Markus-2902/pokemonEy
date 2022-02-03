using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
public class RememberSpriteScript : MonoBehaviour
{
    //string[] skinsstring = Directory.GetFiles(@"Assets/Game/TilesSpritesAndObjects/SkinsStuff/", "*.gif");
    public static List<Sprite> skins = new List<Sprite>();
    public static int currentskinindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        /*foreach (var item in skinsstring)
        {
            skins.Add((Sprite)AssetDatabase.LoadAssetAtPath(item, typeof(Sprite)));
        }
        foreach (var item in skins)
        {
            Debug.Log($"skin: {item.name}");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
