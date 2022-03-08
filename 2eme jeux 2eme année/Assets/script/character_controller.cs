using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_controller : MonoBehaviour
{
    //public GameObject enemy;
    //Rigidbody rb;
    public float mouseSensibility = 100f;
    public Transform Player;

    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;

        xRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, 0f, 90f);

        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        Player.Rotate(Vector3.up * mouseX);
    }
}
