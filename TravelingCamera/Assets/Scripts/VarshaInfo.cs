using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarshaInfo : MonoBehaviour
{
    GameObject rlInfo;
    GameObject nsInfo;
    GameObject vgInfo;
    GameObject mtInfo;
    GameObject psInfo;
    GameObject vpInfo;
    int var1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        rlInfo = GameObject.Find("InfoCube");
        nsInfo = GameObject.Find("InfoCube2");
        vgInfo = GameObject.Find("InfoCube3");
        mtInfo = GameObject.Find("InfoCube4");
        psInfo = GameObject.Find("InfoCube5");
        vpInfo = GameObject.Find("InfoCube6");

    }

    // Update is called once per frame
    void Update()
    {
        if (var1 < 1)
        {
            rlInfo.SetActive(false);
            nsInfo.SetActive(false);
            vgInfo.SetActive(false);
            mtInfo.SetActive(false);
            psInfo.SetActive(false);
            vpInfo.SetActive(false);
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

                    if (hit.transform.gameObject.CompareTag("CabinRL"))
                    {
                        rlInfo.SetActive(true);
                        nsInfo.SetActive(false);
                        vgInfo.SetActive(false);
                       
                    }
                    if (hit.transform.gameObject.CompareTag("CabinNS"))
                    {
                        rlInfo.SetActive(false);
                        nsInfo.SetActive(true);
                        vgInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.CompareTag("CabinVG"))
                    {
                        rlInfo.SetActive(false);
                        nsInfo.SetActive(false);
                        vgInfo.SetActive(true);
                    }
                    if (hit.transform.gameObject.CompareTag("CabinMT"))
                    {
                        mtInfo.SetActive(true);
                        psInfo.SetActive(false);
                        vpInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.CompareTag("CabinPS"))
                    {
                        mtInfo.SetActive(false);
                        psInfo.SetActive(true);
                        vpInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.CompareTag("CabinVP"))
                    {
                        mtInfo.SetActive(false);
                        psInfo.SetActive(false);
                        vpInfo.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "InfoCube")
                    {
                        rlInfo.SetActive(false);
                        nsInfo.SetActive(false);
                        vgInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube2")
                    {
                        rlInfo.SetActive(false);
                        nsInfo.SetActive(false);
                        vgInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube3")
                    {
                        rlInfo.SetActive(false);
                        nsInfo.SetActive(false);
                        vgInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube4")
                    {
                        mtInfo.SetActive(false);
                        psInfo.SetActive(false);
                        vpInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube5")
                    {
                        mtInfo.SetActive(false);
                        psInfo.SetActive(false);
                        vpInfo.SetActive(false);
                    }
                    if (hit.transform.gameObject.name == "InfoCube6")
                    {
                        mtInfo.SetActive(false);
                        psInfo.SetActive(false);
                        vpInfo.SetActive(false);
                    }

                }
            }
        }

    }
}
