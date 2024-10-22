using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
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
            jumpsAmount = 2;
        }

    }
    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpsAmount > 0)
            {
                Debug.Log("jump");
                _rigidbody.velocity = new Vector3(0, jumpForce, 0);
                jumpsAmount -= 1;
            }

        }
    }
}
