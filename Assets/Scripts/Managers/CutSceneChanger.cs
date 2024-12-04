using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    // Duration of the cutscene in seconds
    public float cutsceneDuration = 3.6f;

    // Name of the scene to load after the cutscene
    public string sceneToLoad = "SampleScene3"; // Default value, can be changed in the Inspector

    void Start()
    {
        // Start the coroutine to change the scene after the cutscene duration
        StartCoroutine(ChangeSceneAfterCutscene());
    }

    private IEnumerator ChangeSceneAfterCutscene()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(cutsceneDuration);

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}