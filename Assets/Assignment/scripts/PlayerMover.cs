using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Vector2 direction;
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
    }
}
