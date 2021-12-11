using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentGenerator : MonoBehaviour
{
    public GameObject presentPrefab;
    float spawnRate = 2f, timePassed = 0f;

    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= spawnRate)
        {
            timePassed = 0f;
            spawnRate = Random.Range(1f, 3f);
            Instantiate(presentPrefab, transform.position, transform.rotation);
        }
    }
}
