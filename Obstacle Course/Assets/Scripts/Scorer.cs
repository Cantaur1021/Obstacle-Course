using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int collisionCounter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit") == false)
        {
            collisionCounter += 1;
            Debug.Log("You've bumped into thing this many times: " + collisionCounter);
        }
    }
}
