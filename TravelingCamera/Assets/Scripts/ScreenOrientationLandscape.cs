using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientationLandscape : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }

}
