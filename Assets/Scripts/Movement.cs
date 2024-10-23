using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Movement speed of the player
    public float MovementSpeed = 1;
    private Rigidbody2D _rigidbody;
    public float jumpForce;
    public GameObject GameObject;
    public float jumpsAmount;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("hit ground jumps reset");
            jumpsAmount = 3;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // Get horizontal movement input
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        // Jump logic
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpsAmount > 0)
            {
                Debug.Log("jump");
                _rigidbody.velocity = new Vector3(0, jumpForce, 0);
                jumpsAmount -= 1;
            }
        }

        // Flip the player model when pressing "A" or "D"
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Set the scale on the X-axis to -1
            Vector3 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // Set the scale on the X-axis to 1
            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
        }
    }
}