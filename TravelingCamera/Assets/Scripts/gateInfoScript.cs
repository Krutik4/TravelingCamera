using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gateInfoScript : MonoBehaviour
{
    // Start is called before the first frame update
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
                //Select Stage
                if (hit.transform.name == "AsiaticCube") //Object Name
                {
                    SceneManager.LoadScene("AsiaticInfo");
                }

                if (hit.transform.name == "GatewayCube") //Object Name
                {
                    SceneManager.LoadScene("GatewayInfo");
                }

                if (hit.transform.name == "TajMahalCube") //Object Name
                {
                    //SceneManager.LoadScene("TajInfo");
                }

                if (hit.transform.name == "TajCube") //Object Name
                {
                    SceneManager.LoadScene("TajInfo");
                }

                if (hit.transform.name == "CSTCube") //Object Name
                {
                    SceneManager.LoadScene("CstInfo");
                }

                if (hit.transform.name == "NehruCube") //Object Name
                {
                    SceneManager.LoadScene("NehruInfo");
                }

                if (hit.transform.name == "RajaCube") //Object Name
                {
                    SceneManager.LoadScene("RajabaiInfo");
                }

                if (hit.transform.name == "TajHotelCube") //Object Name
                {
                    SceneManager.LoadScene("TajHotelInfo");
                }

            }
        }

    }
}