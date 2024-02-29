using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int numberOfEnemyObjects = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (numberOfEnemyObjects == 0)
        {
            button.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;

        }
        
    }


}
