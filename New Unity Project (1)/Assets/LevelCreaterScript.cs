using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelCreaterScript : MonoBehaviour
{
    
    public enum myEnum // your custom enumeration
    {
        Grass= 1,
        Street = 2
    };
    public myEnum dropDown;  // this public var should appear as a drop down

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Directory.GetCurrentDirectory());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
