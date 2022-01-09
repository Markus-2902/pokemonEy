using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
    public string MyscoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
    }

    private void Update()
    {
        MyscoreText = ($"Score: {ScoreNum}");
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 40), MyscoreText);
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Mycoin")
        {
            ScoreNum++;
            MyscoreText = ($"Score: {ScoreNum}");
            Destroy(Coin.gameObject);
        }
        else if (Coin.tag == "Myredcoin")
        {
            ScoreNum+=2;
            MyscoreText = ($"Score: {ScoreNum}");
            Destroy(Coin.gameObject);
        }
    }
}
