using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTeleport : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    // Flag to check if player is in range
    private bool playerInRange;

    private void Update()
    {
        // Check if the player presses the interact key (E) and is in range
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            playerInRange = true; // Set the flag to true
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object exiting the trigger is the player
        if (other.CompareTag("Player"))
        {
            playerInRange = false; // Set the flag to false
        }
    }
}