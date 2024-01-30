using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject movingplatform;
    public Transform spawnpoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision detected");
        Instantiate(movingplatform, spawnpoint.position, spawnpoint.rotation);
    }
    }
