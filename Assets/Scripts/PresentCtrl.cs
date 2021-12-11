using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentCtrl : MonoBehaviour
{
    public static float speed = 0.01f;
    float spawnRate = 3f, timePassed = 0f;

    void Update()
    {
        transform.Translate(Vector3.down * speed);
        Destroy(gameObject, 5f);

        timePassed += Time.deltaTime;

        if (timePassed >= spawnRate)
        {
            GameDirector.isCheck = true;
            timePassed = 0f;
        }
    }
}
