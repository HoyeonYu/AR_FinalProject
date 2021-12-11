using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefCtrl : MonoBehaviour
{
    public static float speed = 0.01f, presentDistance = 0f;
    public static int score = 0;
    public static bool isWin = false;
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed);

            animator.SetBool("isIdle", false);
            animator.SetBool("isRun", true);
            animator.SetBool("isJump", false);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-1 * Vector3.right * speed);

            animator.SetBool("isIdle", false);
            animator.SetBool("isRun", true);
            animator.SetBool("isJump", false);
        }

        else if (isWin)
        {
            score++;
            isWin = false;

            animator.SetBool("isIdle", false);
            animator.SetBool("isRun", false);
            animator.SetBool("isJump", true);

            Debug.Log("thief score" + score);
        }

        else
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isRun", false);
            animator.SetBool("isJump", false);
        }

        GameObject present = GameObject.FindGameObjectWithTag("Present");

        if (present != null)
        {
            presentDistance = Vector3.Distance(transform.position, present.transform.position);
        }

        else
        {
            presentDistance = 0f;
        }
    }
}
