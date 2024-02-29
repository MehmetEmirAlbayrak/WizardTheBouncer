using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    
    private Animator animator;



    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
            animator.SetBool("isDeath", true);

        if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.tag = "Untagged";
            animator.SetBool("isDeath", true);


        }
    }
}
