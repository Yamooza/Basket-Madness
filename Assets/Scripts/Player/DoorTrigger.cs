using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Reference to the door GameObject
    public GameObject Door;

    private void Start()
    {
        // Ensure the door is inactive at the start
        if (Door != null)
        {
            Door.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Activate the door GameObject
            if (Door != null)
            {
                Door.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Optional: You can deactivate the door again when the player exits the trigger
        // Uncomment the following lines if you want this behavior
        /*
        if (other.CompareTag("Player"))
        {
            if (door != null)
            {
                door.SetActive(false);
            }
        }
        */
    }
}