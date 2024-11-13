using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    // Reference to the SpriteRenderer component
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component attached to the player
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the tag "EE"
        if (other.CompareTag("EE"))
        {
            // Change the player's sprite color to yellow
            spriteRenderer.color = Color.yellow;

            // Optionally, you can destroy the Easter egg object after collecting it
            Destroy(other.gameObject);
        }
    }
}