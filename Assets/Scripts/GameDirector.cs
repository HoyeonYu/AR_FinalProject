using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    float santaDistance, thiefDistance, checkDistance = 5f;
    public static bool isCheck = false;

    void Update()
    {
        santaDistance = SantaCtrl.presentDistance;
        thiefDistance = ThiefCtrl.presentDistance;

        GameObject present = GameObject.FindGameObjectWithTag("Present");

        if (present != null && isCheck)
        {
            if (santaDistance < thiefDistance)
            {
                SantaCtrl.isWin = true;
                ThiefCtrl.isWin = false;

                Debug.Log("win? SantaCtrl");
            }

            else
            {
                SantaCtrl.isWin = false;
                ThiefCtrl.isWin = true;

                Debug.Log("win? ThiefCtrl");
            }

            Destroy(present);
            isCheck = false;
        }

        else
        {
            SantaCtrl.isWin = false;
            ThiefCtrl.isWin = false;
        }
    }
}
