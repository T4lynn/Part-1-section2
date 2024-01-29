using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    Vector2 startpos; 
    Vector2 endpos;
    public Vector2 increment = Vector2.right;
    public Vector2 negincrement = Vector2.left;

    void Start()
    {
        startpos = new Vector2(2, 0);
        endpos = new Vector2(5, 0);
        
    }

    
    void Update()
    {
       if (transform.position.x < endpos.x)
        {
            transform.Translate(negincrement * Time.deltaTime);
        } //else if (transform.position.x < startpos.x)
      //  {
          //  transform.Translate(negincrement * Time.deltaTime);
     //   }
            
       

        
    }
}
