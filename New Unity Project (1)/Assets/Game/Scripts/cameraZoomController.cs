using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomController : MonoBehaviour
{
    //kameraobjekt zuweisen
    private Camera cam;
    //
    private float targetZoom;
    //wieviel der zoom sein soll
    private float zoomFactor = 3f;
    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
        targetZoom = zoomFactor;
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime);
    }
    void Update()
    {
        
    }
}
