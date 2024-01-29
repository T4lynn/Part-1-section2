using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    Vector2 startpos; 
    Vector2 endpos;
    public Vector2 increment = Vector2.right;

    void Start()
    {
        startpos = new Vector2(2, 0);
        endpos = new Vector2(5, 0);
        
    }

    
    void Update()
    {
        if (transform.position.x > endpos.x)
        {
            increment = increment * -1;
        } else if (transform.position.x < startpos.x)
        {
            increment = increment * -1;
        }
            transform.Translate(increment * Time.deltaTime);  
    }
}
