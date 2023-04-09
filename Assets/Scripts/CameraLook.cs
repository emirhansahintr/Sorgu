using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{   
    [Range(10,250)]
    public float mouseSensitivity = 100f;
    float clampValueY = 30f;
    float clampValueX = 50f;
    float xRot;
    float yRot;
    
    void Start()
    {
        transform.localRotation=Quaternion.Euler(0,0,0);
        Cursor.lockState=CursorLockMode.Locked;
        //Cursor.visible=false;
    }

    void LateUpdate()
    {
        float MouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        xRot -= MouseY;
        xRot = Mathf.Clamp(xRot,-clampValueY, clampValueY);
        yRot +=MouseX;
        yRot=Mathf.Clamp(yRot,-clampValueX,clampValueX);
        transform.localRotation = Quaternion.Euler(xRot, yRot, 0.0f);
    }
}
