using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Vector2 direction;
    Vector2 upwards;
    public int jumpforce;
    public float speed = 3;
   Rigidbody2D rb2D;
    void Start()
    {
         
       rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
        direction = new Vector2(speed * Input.GetAxis("Horizontal"), rb2D.velocity.y);
        rb2D.MovePosition(rb2D.position + direction * Time.deltaTime);

        
    }
}
