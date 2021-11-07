using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //target informationen bekommen
    public Transform target;

    //definiert wie schnell die Kamera zum player springt (zwischen 0 und 1)
    public float smoothSpeed = 0.125f;

    //exestiert damit man die positionierung der kamera etwas besser ändern kann
    public Vector3 offset;

    //wird direkt nach allen Update Methoden ausgeführt
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
