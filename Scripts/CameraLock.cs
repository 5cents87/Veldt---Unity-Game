using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{            
    // Update is called once per frame   
    void Update ()
    {
        GameObject ball = GameObject.Find("Veldt Ball");
        if (ball != null)
        {
            // Camera positioning.
            Vector3 offset = new Vector3(0, 13, 15);
            gameObject.transform.position = ball.transform.position + offset;
        }
    } 
}
