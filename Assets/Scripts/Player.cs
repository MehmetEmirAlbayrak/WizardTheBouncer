using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject BallPrefab; // Use a prefab for the ball
    [SerializeField] private float ballSpeed;


    [SerializeField] private GameObject button;
    private bool isShooted=false;
    private Vector3 playerChildLocation;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !isShooted)
        {
            isShooted = true;
            Vector3 destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           
            destination.z = 0;
            
            
            playerChildLocation = player.transform.GetChild(0).transform.position;
            playerChildLocation.z = 0;

            GameObject new_ball = Instantiate(BallPrefab, playerChildLocation, Quaternion.identity);
            Rigidbody2D rb = new_ball.GetComponent<Rigidbody2D>();

            Vector3 direction = (destination - playerChildLocation).normalized;
            rb.velocity = direction * ballSpeed;
            
           
        }
        if (GameObject.FindGameObjectsWithTag("Ball").Length == 0)
            isShooted = false;
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Enemy"))
        {
            animator.SetBool("isHit", true);

            button.SetActive(true);

            Cursor.visible = true;

        }
    }
}


