using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TajClick : MonoBehaviour
{
    int var1 = 0;
    int var2 = 0;
    int var3 = 0;
    GameObject infoCube;
    GameObject nearCube;
    GameObject modelCube;
    GameObject bodyCube;

    void Start()
    {
        infoCube = GameObject.Find("MoreTaj");
        nearCube = GameObject.Find("NearTaj");
        modelCube = GameObject.Find("ModelTaj");
        bodyCube = GameObject.Find("TajModel");

    }

    // Update is called once per frame
    void Update()
    {
        if (var1 == 0)
        {
            infoCube.SetActive(false);
            nearCube.SetActive(false);
            modelCube.SetActive(false);
            bodyCube.SetActive(false);
            var1 = 1;
        }
        if (Input.GetMouseButtonDown(0)) //Mouse Click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "TajMahalCube") //Object Name
                {
                    if (var2 == 0)
                    {
                        infoCube.SetActive(true);
                        nearCube.SetActive(true);
                        modelCube.SetActive(true);
                        //bodyCube.SetActive(false);
                        var2 = 1;
                        Debug.Log("var2 = 1");
                    }
                    else
                    {
                        infoCube.SetActive(false);
                        nearCube.SetActive(false);
                        modelCube.SetActive(false);
                        bodyCube.SetActive(false);
                        var2 = 0;
                        Debug.Log("var2 = 0");

                    }
                    //SceneManager.LoadScene("TajInfo");

                }

                if (hit.transform.name == "MoreTaj") //Object Name
                {
                    SceneManager.LoadScene("TajInfo");
                }

                if (hit.transform.name == "NearTaj") //Object Name
                {
                   SceneManager.LoadScene("TajNearby");
                }

                if (hit.transform.name == "ModelTaj") //Object Name
                {
                    if (var3 == 0)
                    {
                        
                        bodyCube.SetActive(true);
                        var3 = 1;
                    }
                    else if (var2 > 0)
                    {
                        bodyCube.SetActive(false);
                        var3 = 0;

                    }

                }

            }

        }

    }
}
