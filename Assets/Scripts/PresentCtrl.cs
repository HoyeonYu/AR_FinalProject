using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentCtrl : MonoBehaviour
{
    public static float speed = 0.03f;

    void Update()
    {
        transform.Translate(Vector3.down * speed);
        Destroy(gameObject, 5f);
    }
}
