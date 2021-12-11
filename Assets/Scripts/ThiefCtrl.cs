using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefCtrl : MonoBehaviour
{
    public static float speed = 0.005f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed);
            Debug.Log("LEFT");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-1 * Vector3.right * speed);
            Debug.Log("RIGHT");
        }
    }
}
