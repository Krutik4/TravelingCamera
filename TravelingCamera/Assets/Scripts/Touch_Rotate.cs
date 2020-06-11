using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Rotate : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, - touchDeltaPosition.x * 0.1f, 0);
        }
        
    }
}
