using UnityEngine;
using System.Collections;
 
public class RotateObject : MonoBehaviour {
    
    float rotSpeed = 20;

    void onMouseDrag(){
        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;
        
        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);

    }
}