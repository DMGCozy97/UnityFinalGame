using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public transform playerBody;

    float xRotation = 0f;

	
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float mouseX = Input.Getxis("MouseX") * mouseSensitivity * time.deltaTime;
        float mouseY = Input.Getxis("MouseY") * mouseSensitivity * time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transfrom.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
