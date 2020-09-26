using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public GameObject FadePanel;

    private void Start()
    {
        FadePanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        StartCoroutin(FadeEffect(SceneManager.GetActiveScene().buildIndex));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        StartCoroutin(FadeEffect(SceneManager.GetActiveScene().buildIndex+1));
        //SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%SceneManager.sceneCountInBuildSettings);
    }

    IEnumerator FadeEffect(int SceneToLoad)
    {
        object p = FadePanel.SetActive(true);
        for (int i = 0; i < 100; i++)
        {
            FadePanel.GetComponent < CanvasGroup().alpha = (float)i * 0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }
}
