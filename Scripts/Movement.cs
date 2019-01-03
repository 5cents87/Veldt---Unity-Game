using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;
    Rigidbody eyeballRigidBody;
    public float rollSpeed = 7f;
    public float velocity = 10f;
    public float extraForce = 1.7f;
    float horizontalSpeed;

    void Start()
    {
        // Ensures mouse pointer dissapears when game is running.
        Cursor.lockState = CursorLockMode.Locked;
    }
   
    // Updates as long as the ball is alive.
    void Update()
    {
        if (gameObject != null)
        {
            Move();
        }        
    }

    void SetHorizontalSpeed()
    {
        // Formulates the x axis movement speed.
        horizontalSpeed = Input.GetAxis("Horizontal") * velocity * Time.deltaTime * extraForce;
    }

    void SetBallRollSpeed()
    {
        SetHorizontalSpeed();
        eyeballRigidBody = gameObject.GetComponent<Rigidbody>();
        eyeballRigidBody.AddForce(eyeballRigidBody.velocity.normalized * rollSpeed);
    }

    void Move()
    {
        SetBallRollSpeed();
        // Moves ball on the x axis.
        transform.Translate(horizontalSpeed, 0, 0);      
    }

    // Tree Collision.
    void OnCollisionEnter(Collision treeCollider)
    {
        if (treeCollider.gameObject.name == "Tree")
        {
            // Destroy ball + sound and particles.      
            ExplodeAndPlayAudio();
        }
    }

    // Plays both explosion particle and sound.
    void ExplodeAndPlayAudio()
    {
        explosionParticle.Play();
        explosionAudio.Play();
        Destroy(gameObject);
    }
}





