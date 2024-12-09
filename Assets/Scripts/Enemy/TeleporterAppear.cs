using UnityEngine;

public class TeleporterAppear : MonoBehaviour
{
    public GameObject teleporter; // Reference to the teleporter GameObject
    private EnemyHealth enemyHealth; // Reference to the EnemyHealth component

    void Start()
    {
        // Get the EnemyHealth component from the enemy GameObject
        enemyHealth = GetComponent<EnemyHealth>();

        // Check if the EnemyHealth component is found
        if (enemyHealth == null)
        {
            Debug.LogError("TeleportAppear: EnemyHealth component not found on this GameObject.");
        }

        // Initially deactivate the teleporter
        if (teleporter != null)
        {
            teleporter.SetActive(false);
        }
    }

    void Update()
    {
        // Check if the enemy is dead
        if (enemyHealth != null && enemyHealth.IsDead())
        {
            ActivateTeleporter();
        }
    }

    private void ActivateTeleporter()
    {
        // Activate the teleporter
        if (teleporter != null)
        {
            teleporter.SetActive(true);
            Debug.Log("Teleporter activated!");
        }

        // Optionally, disable this script after activation
        this.enabled = false;
    }
}