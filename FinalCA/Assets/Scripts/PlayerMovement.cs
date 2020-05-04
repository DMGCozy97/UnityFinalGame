using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //float mouseX;
    //public float rotationSpeed = 2;

    public CharacterController controller;

    public float speed = 12f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.move(move * speed * time.deltaTime);

        //mouseX = Input.GetAxisRaw("Mouse X");

        ////rotate on the Y axis
        //transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
