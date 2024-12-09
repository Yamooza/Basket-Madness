using UnityEngine.SceneManagement;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Optional: You can add logic here if you want to do something when the player exits the trigger
        if (other.CompareTag("Player"))
        {
            // You can leave this empty or add any exit logic if needed
        }
    }
}