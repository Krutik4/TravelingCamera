using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float transitiontime = 1f;

    public void LevelAR()
    {
        StartCoroutine(LoadLevelAR(26));
    }

    public void LevelInfo()
    {
        StartCoroutine(LoadLevelAR(19));
    }

    public void LevelTour()
    {
        StartCoroutine(LoadLevelAR(3));
    }
    public void LevelHome()
    {
        StartCoroutine(LoadLevelAR(0));
    }

    public void LevelIT()
    {
        StartCoroutine(LoadLevelAR(4));
    }

    public void ChangeScene(string scenename)
    {
        StartCoroutine(LoadLevel2(scenename));
    }

    public void LevelExit()
    {
        Application.Quit();
    }

    IEnumerator LoadLevelAR(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelIndex);

    }
    IEnumerator LoadLevel2(string sname)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(sname);

    }
}
