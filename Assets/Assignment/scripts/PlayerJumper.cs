using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    public int jumpforce = 10;
    public Rigidbody2D rb2D;
    Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            direction = new Vector2(0, 1 * jumpforce);
            rb2D.velocity = direction;
        }
      
    }
}
