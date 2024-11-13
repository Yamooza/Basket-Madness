using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerTeleporter : MonoBehaviour
{
    // Name of the scene to load
    public string sceneToLoad;

    // Optional: LayerMask to specify which objects can trigger the teleport
    public LayerMask playerLayer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding is the player
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}