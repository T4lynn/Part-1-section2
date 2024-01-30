using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reward : MonoBehaviour
{
    public SpriteRenderer render;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");
        render.color = Color.yellow;
    }
}
