using UnityEngine;
using System.Collections;

public class TeleportAppear : MonoBehaviour
{
    public GameObject teleporter; // Reference to the teleporter GameObject
    private EnemyHealth enemyHealth; // Reference to the EnemyHealth component
    public float delayTime = 3f; // Delay time in seconds before activating the teleporter

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
            // Start the coroutine to activate the teleporter after a delay
            StartCoroutine(ActivateTeleporterWithDelay());
        }
    }

    private IEnumerator ActivateTeleporterWithDelay()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delayTime);

        // Activate the teleporter
        if (teleporter != null)
        {
            teleporter.SetActive(true);
            Debug.Log("Teleporter activated after delay!");
        }

        // Optionally, disable this script after activation
        this.enabled = false;
    }
}