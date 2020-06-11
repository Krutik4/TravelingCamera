using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrishmaInfo : MonoBehaviour
{
    GameObject srInfo;
    GameObject mrInfo;
    int var1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        srInfo = GameObject.Find("InfoCube");
        mrInfo = GameObject.Find("InfoCube2");

    }

    // Update is called once per frame
    void Update()
    {
        if (var1 < 1)
        {
            srInfo.SetActive(false);
            mrInfo.SetActive(false);
            var1 = var1 + 1;
            Debug.Log("var1 loop");
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    Debug.Log(hit.transform.gameObject.name);

                    if (hit.transform.gameObject.CompareTag("CabinSR"))
                    {
                        srInfo.SetActive(true);
                        mrInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.CompareTag("CabinMR"))
                    {
                        mrInfo.SetActive(true);
                        srInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube")
                    {
                        srInfo.SetActive(false);
                        mrInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube2")
                    {
                        srInfo.SetActive(false);
                        mrInfo.SetActive(false);
                    }

                }
            }
        }

    }
}
