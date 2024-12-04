using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door; // Reference to the door object

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Get the DoorTeleport script component on the door object
            DoorTeleport doorTeleport = door.GetComponent<DoorTeleport>();

            // Check if the script is found and enable it
            if (doorTeleport != null)
            {
                doorTeleport.enabled = true;
                Debug.Log("Door Teleport script activated.");
            }
            else
            {
                Debug.LogWarning("DoorTeleport script not found on the door object.");
            }
        }
    }

}