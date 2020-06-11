using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimateLabScript : MonoBehaviour
{
    public Animator transition;
    public float transitiontime = 1f;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "SharadRoof")
                    {
                        StartCoroutine(LoadLevelAR(5));
                    }
                    else if (hit.transform.gameObject.name == "ShishirRoof")
                    {
                        StartCoroutine(LoadLevelAR(6));
                    }
                    else if (hit.transform.gameObject.name == "VasantRoof")
                    {
                        StartCoroutine(LoadLevelAR(10));
                    }
                    else if (hit.transform.gameObject.name == "VarshaRoof")
                    {
                        StartCoroutine(LoadLevelAR(9));
                    }
                    else if (hit.transform.gameObject.name == "GrishmaRoof")
                    {
                        StartCoroutine(LoadLevelAR(7));
                    }
                    else if (hit.transform.gameObject.name == "HemantRoof")
                    {
                        StartCoroutine(LoadLevelAR(8));
                    }


                }

            }

        }

    }

    IEnumerator LoadLevelAR(int levelIndex)
    {
        if (levelIndex == 6)
        {
            transition.SetTrigger("shishir");
            yield return new WaitForSeconds(transitiontime);
            
        }
        else if (levelIndex == 5)
        {
            transition.SetTrigger("sharad");
            yield return new WaitForSeconds(transitiontime);
            
        }
        else if (levelIndex == 7)
        {
            transition.SetTrigger("grishma");
            yield return new WaitForSeconds(transitiontime);
            
        }
        else if (levelIndex == 8)
        {
            transition.SetTrigger("hemant");
            yield return new WaitForSeconds(transitiontime);

        }
        else if (levelIndex == 9)
        {
            transition.SetTrigger("varsha");
            yield return new WaitForSeconds(transitiontime);
        }
        else if (levelIndex == 10)
        {
            transition.SetTrigger("vasant");
            yield return new WaitForSeconds(transitiontime);
        }
        
        SceneManager.LoadScene(levelIndex);


    }
}
