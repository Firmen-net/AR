using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int waittime = 3;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator GoToARScene()
    {
        yield return new WaitForSeconds(waittime);
        SceneManager.LoadScene("ARScene");
    }

    public void GoToArSceneWithDelay()
    {
        StartCoroutine(GoToARScene());
    }

    private IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(waittime);
        Application.Quit();
    }

    public void ExitWithDelay()
    {
        StartCoroutine(ExitGame());
    }

    private IEnumerator GoToStartScene()
    {
        yield return new WaitForSeconds(waittime);
        SceneManager.LoadScene("StartScene");
    }

    public void GoToStartSceneWithDelay()
    {
        StartCoroutine(GoToStartScene());
    }
}