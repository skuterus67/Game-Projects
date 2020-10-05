using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int sceneToLoadIndex;
    [SerializeField] int waitSeconds = 3;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadStartScreen();
        }
    }

    public void LoadStartScreen()
    {
        StartCoroutine(WaitAndLoad(sceneToLoadIndex, waitSeconds));
    }

    IEnumerator WaitAndLoad(int sceneIndex, int seconds)
    {
        yield return new WaitForSeconds(seconds);
        LoadNextScene(sceneIndex);
    }

    public void LoadNextScene(int currentIndex)
    {
        SceneManager.LoadScene(currentIndex);
    }

}
