using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Vector2 direction;
    public float speed = 3;
   Rigidbody2D rb2D;
    bool keyheld = false;
    void Start()
    {
         
       rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        direction = new Vector2(speed, rb2D.velocity.y);
        if (Input.GetAxis("Horizontal") == 1)
        {
            Debug.Log("pos. direction triggered");
            keyheld = true;
            rb2D.AddForce(direction, ForceMode2D.Force);
        } else if (Input.GetAxis("Horizontal") == -1)
        {
            Debug.Log("neg. direction triggered");
            keyheld = true;
            rb2D.AddForce(-direction, ForceMode2D.Force);
        } else
        {
            keyheld = false;
            Debug.Log("false");
        }

       
        
    }
}
