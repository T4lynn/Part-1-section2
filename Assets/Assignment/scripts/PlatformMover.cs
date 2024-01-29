using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    //start and end positions as vectors
    Vector2 startpos; 
    Vector2 endpos;
    //increment of one
    public Vector2 increment = Vector2.right;

    void Start()
    {
        //initializing vectors
        startpos = new Vector2(2, 0);
        endpos = new Vector2(5, 0);
        
    }

    
    void Update()
    {
        //if the position of the gameobject is past a certain point, it reverses direction.
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
