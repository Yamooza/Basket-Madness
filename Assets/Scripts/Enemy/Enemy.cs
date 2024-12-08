using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float followRange = 5f; // Distance within which the enemy will follow the player
    public float moveSpeed = 2f; // Speed at which the enemy moves
    public float stopDistance = 1f; // Distance at which the enemy stops following the player
    public float jumpForce = 5f; // Force applied when the enemy jumps
    public LayerMask groundLayer; // Layer to identify ground
    public Transform groundCheck; // Transform to check if the enemy is grounded
    public float groundCheckRadius = 0.2f; // Radius for ground check

    private Rigidbody2D rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if the enemy is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Check if the player is within follow range
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < followRange)
        {
            // Move towards the player if they are within range
            if (distanceToPlayer > stopDistance)
            {
                Vector2 direction = (player.position - transform.position).normalized;
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

                // Rotate the enemy sprite based on direction
                if (direction.x < 0)
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0); // Rotate to face left
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0); // Rotate to face right
                }

                // Check if the enemy is stuck and jump
                if (!isGrounded)
                {
                    Jump();
                }
            }
        }
    }

    private void Jump()
    {
        // Apply a vertical force to make the enemy jump
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}