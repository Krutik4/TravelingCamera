using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInfo : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject ProfInfo;
    int var1 = 0;
    void Start()
    {
        
        ProfInfo = GameObject.Find("InfoCube");

    }

    // Update is called once per frame
    void Update()
    {
        if (var1 < 1)
        {
            ProfInfo.SetActive(false);
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

                    if (hit.transform.gameObject.CompareTag("CabinHB") )
                    {
                        Debug.Log(hit.transform.gameObject.name);
                        Debug.Log("Cabin Clicked");
                        ProfInfo.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "InfoCube")
                    {
                        ProfInfo.SetActive(false);
                    }
                    
                }
            }
        }
    }
}
