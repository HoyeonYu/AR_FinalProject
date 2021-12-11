using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaCtrl : MonoBehaviour
{
    public static float speed = 0.005f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * speed);
            Debug.Log("LEFT");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-1 * Vector3.right * speed);
            Debug.Log("RIGHT");
        }
    }
}
