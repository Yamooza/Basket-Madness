using UnityEngine;

public class BulletDestoy : MonoBehaviour
{
    // Time in seconds before the bullet is destroyed
    private float lifetime = 6f;

    void Start()
    {
        // Destroy the bullet after the specified lifetime
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the bullet
            Destroy(gameObject);
        }
    }

    // If you are using triggers instead of colliders, use this method instead
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has the tag "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}