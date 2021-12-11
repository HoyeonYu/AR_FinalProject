using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaCtrl : MonoBehaviour
{
    public static float speed = 0.01f;
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * speed);

            animator.SetBool("isIdle", false);
            animator.SetBool("isRun", true);
            animator.SetBool("isJump", false);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-1 * Vector3.right * speed);

            animator.SetBool("isIdle", false);
            animator.SetBool("isRun", true);
            animator.SetBool("isJump", false);
        }

        else
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isRun", false);
            animator.SetBool("isJump", false);
        }
    }
}
