using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVarsAcreossScenesScript : MonoBehaviour
{
    public static int Coins = 0;
    public static double Seconds = 0;
    public static double Timer = 0;
    public static GameObject activeitem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        activeitem = ItemBehaviorScript.activeitem;
        Coins = CoinCollection.ScoreNum;
        Timer = timerscript.timer;
    }

    private void Awake()
    {
        
    }
}
