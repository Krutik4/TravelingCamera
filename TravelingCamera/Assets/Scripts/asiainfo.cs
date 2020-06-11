using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class asiainfo : MonoBehaviour
{
    public Animator transition;
    public float transitiontime = 1f;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse Click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.name == "AsiaticCube")
                {
                    Debug.Log("Clicked");
                    StartCoroutine(asia());

                }

            }
        }

    }

    IEnumerator asia()
    {
        transition.SetTrigger("click");
        yield return new WaitForSeconds(transitiontime);
        Debug.Log("entered");
        //SceneManager.LoadScene(levelIndex);
    }
}
