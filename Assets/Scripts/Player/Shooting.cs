using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab; // The projectile prefab to be instantiated
    public Transform shootPoint; // The point from where the projectile will be shot
    public float projectileSpeed = 10f; // Speed of the projectile
    public float fireRate = 0.5f; // Time between shots

    public AudioSource src;
    public AudioClip sfx2;

    private float nextFireTime = 0f; // Time when the player can fire again

    void Update()
    {
        // Check if the player presses the Space key
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // Set the next fire time
        }

        void Shoot()
        {
            // Instantiate the projectile at the shoot point
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

            // Get the Rigidbody2D component of the projectile
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            src.clip = sfx2;
            src.Play();

            // Set the velocity of the projectile
            if (rb != null)
            {
                rb.velocity = shootPoint.up * projectileSpeed; // Shoot in the direction of the shoot point
            }
        }
    }
}
