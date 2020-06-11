using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(0);
    }
}
