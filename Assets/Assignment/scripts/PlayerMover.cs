using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Vector2 direction;
    public int jumpforce;
    public float speed = 3;
   Rigidbody2D rb2D;
    void Start()
    {
         
       rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction = new Vector2(speed * Input.GetAxis("Horizontal"), 0);
    }
    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direction * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb2D.AddForce(new Vector2(rb2D.velocity.x, jumpforce));
        } 
    }
}
