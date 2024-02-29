using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    
    private int getCollide = 0;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Block"))
        { 
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //try again
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //decrease enemy if enemy count equals to 0 open next level
            

            collision.gameObject.tag = "Untagged";
            Destroy(gameObject);
            



        }
        if (getCollide>5)
        {
            Destroy(gameObject);
        }
        getCollide++;
        
    }

}
