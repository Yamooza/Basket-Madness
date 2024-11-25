using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    // Duration of the cutscene in seconds
    public float cutsceneDuration = 3.8f;

    void Start()
    {
        // Start the coroutine to change the scene after the cutscene duration
        StartCoroutine(ChangeSceneAfterCutscene());
    }

    private IEnumerator ChangeSceneAfterCutscene()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(cutsceneDuration);

        // Load the main game scene
        // Replace "MainGameScene" with the name of your main game scene
        SceneManager.LoadScene("SampleScene3");
    }
}