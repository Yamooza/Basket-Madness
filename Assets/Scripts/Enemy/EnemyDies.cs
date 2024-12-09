using UnityEngine;

public class EnemyDies : MonoBehaviour
{
    private EnemyHealth enemyHealth;
    private bool isFlipping = false;
    private float rotationSpeed = 30f; // Degrees per second
    private float downwardSpeed = 1f; // Units per second
    private Vector3 targetRotation = new Vector3(0, 0, -90); // Target rotation
    private Vector3 targetPosition = new Vector3(0, -1, 0); // Target position

    void Start()
    {
        // Get the EnemyHealth component
        enemyHealth = GetComponent<EnemyHealth>();

        // Check if the EnemyHealth component is found
        if (enemyHealth == null)
        {
            Debug.LogError("EnemyFlip: EnemyHealth component not found on this GameObject.");
        }
    }

    void Update()
    {
        // Check if the enemy is dead and start the flipping process
        if (enemyHealth != null && enemyHealth.IsDead() && !isFlipping)
        {
            isFlipping = true;
        }

        // If flipping, perform the rotation and downward movement
        if (isFlipping)
        {
            RotateAndMoveDown();
        }
    }

    private void RotateAndMoveDown()
    {
        // Smoothly rotate towards the target rotation
        Quaternion targetQuaternion = Quaternion.Euler(targetRotation);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, rotationSpeed * Time.deltaTime);

        // Move downwards towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, downwardSpeed * Time.deltaTime);

        // Check if the rotation and position have reached their targets
        if (Quaternion.Angle(transform.rotation, targetQuaternion) < 0.1f && Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // Optionally, you can disable this script after the action is complete
            this.enabled = false;
        }
    }
}