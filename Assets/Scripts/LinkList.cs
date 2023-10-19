using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.WSA;

public class LinkList : MonoBehaviour
{
    public float sensitivity;
    public float mouseOffset;
    public float rotationSensitivity;

    void Update()
    {
        ControllSnakeMovement();
    }

    private void ControllSnakeMovement()
    {
        // Get the mouse's X position in screen coordinates
        float mouseX = Input.mousePosition.x;

        // Convert screen coordinates to world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, 0, mouseOffset)); // The '10' is the distance from the camera
        // Update the GameObject's X position with sensitivity
        transform.position = new Vector3(mousePos.x * sensitivity * Time.deltaTime, transform.position.y, transform.position.z);

        Debug.Log(Input.mousePosition.x);
        //  transform.Rotate(Vector3.up * steerDirection * rotationSensitivity * Time.deltaTime);

        // Rotate the GameObject around the Y-axis
    }
}
