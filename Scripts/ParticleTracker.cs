using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTracker : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
        GameObject ball = GameObject.Find("Veldt Ball");
        if(ball != null)
        gameObject.transform.position = GameObject.Find("Veldt Ball").transform.position;
	}
}
