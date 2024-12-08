using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    [Header("Damage Settings")]
    public int damage = 10; // Damage dealt by the projectile

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the EnemyHealth component
        EnemyHealth enemyHealth = collision.collider.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            // Deal damage to the enemy
            enemyHealth.TakeDamage(damage);

            // Destroy the projectile after hitting an enemy
            Destroy(gameObject);
        }
    }
}