using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    float drag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        drag = collision.attachedRigidbody.angularDrag;
        collision.attachedRigidbody.angularDrag =0;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.attachedRigidbody.angularDrag = drag;
    }
}
