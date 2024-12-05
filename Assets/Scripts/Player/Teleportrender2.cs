using UnityEngine;
using System.Collections; // Make sure to include this for IEnumerator

public class Teleportrender2 : MonoBehaviour
{
    public float visibilityDuration = 2.0f; // Time in seconds to keep the portal visible
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Get the SpriteRenderer component attached to this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Start the visibility coroutine
        StartCoroutine(ManagePortalVisibility());
    }

    private IEnumerator ManagePortalVisibility() // Ensure this is IEnumerator
    {
        while (true) // Loop indefinitely
        {
            // Disable the SpriteRenderer
            spriteRenderer.enabled = false;

            // Wait for the specified duration
            yield return new WaitForSeconds(visibilityDuration);

            // Enable the SpriteRenderer
            spriteRenderer.enabled = true;

            // Wait for the specified duration before enabling again
            yield return new WaitForSeconds(visibilityDuration);
        }
    }
}