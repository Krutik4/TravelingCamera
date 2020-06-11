using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientationPotrait : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

}
