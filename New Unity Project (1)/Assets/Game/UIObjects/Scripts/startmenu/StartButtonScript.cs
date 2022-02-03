using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonScript : MonoBehaviour
{
    public GameObject obj;
    float scalechangex;
    float scalechangey;
    float poschangex;
    //float transpchangea;
    Vector3 scalechanges;
    Vector3 poschanges;
    Color transpchanges;
    bool? move = null;
    bool? expand = null;
    bool? transp = null;
    //Shader shad;
    //Color mycolor;
    float olda = 1F;

    // Start is called before the first frame update
    void Start()
    {
        scalechangex = 0.0495F;
        scalechangey = 0.0445F;
        poschangex = 0.0082F;
        //transpchangea = 0.0034F;
        
        scalechanges = new Vector3(scalechangex, scalechangey);
        poschanges = new Vector3(poschangex, 0);
        //mycolor = new Color(1F, 1F, 1F, 1F);
        //position = obj.transform.position;
        //obj.GetComponent<SpriteRenderer>().material.color = new Color(obj.GetComponent<SpriteRenderer>().material.color.r, obj.GetComponent<SpriteRenderer>().material.color.g, obj.GetComponent<SpriteRenderer>().material.color.b, 1.0F);
        //transpchanges = new Color(0f, 0f, 0f, transpchangea);
        //obj.GetComponent<SpriteRenderer>().material.color = new Color(obj.GetComponent<SpriteRenderer>().material.color.r, obj.GetComponent<SpriteRenderer>().material.color.g, obj.GetComponent<SpriteRenderer>().material.color.b, (0.0034F));
    }

    // Update is called once per frame
    void Update()
    {
        
        if (expand==true)
        {
            if (obj.transform.localScale.x<4.95F && obj.transform.localScale.y<4.45F)
            {
                obj.transform.localScale += scalechanges;
            }
            else
            {
                Debug.Log("scale Done");
                expand = false;
            }
           
        }
        if (move == true)
        {
            if (obj.transform.position.x > -0.82F)
            {
                obj.transform.position -= poschanges;
                Debug.Log("poschange");
            }
            else
            {
                Debug.Log("position Done");
                move = false;
            }
        }
        if (transp==true)
        {

            if (obj.GetComponent<SpriteRenderer>().material.color.a > 0.34F)
            {
                olda = obj.GetComponent<SpriteRenderer>().material.color.a;
                obj.GetComponent<SpriteRenderer>().material.color = new Color(obj.GetComponent<SpriteRenderer>().material.color.r, obj.GetComponent<SpriteRenderer>().material.color.g, obj.GetComponent<SpriteRenderer>().material.color.b, (olda - 0.0034F));
            }
            else
            {
                Debug.Log("transp done");
                transp = false;
            }
        }

        

    }

    private void OnMouseDown()
    {
        if (transp==null && move==null && expand == null)
        {
            expand = true;
            move = true;
            transp = true;
            Debug.Log("Lol");
        }
        else if (transp == false && move == false && expand == false)
        {
            SceneManager.LoadScene("3Scene_LevelMeWithSkinselector");
            Debug.Log("lolllllll");
        }
    }
}
