using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookFPC : MonoBehaviour
{
    public float moveSpeed = 100f;

    public Transform fpc;

    float xRot = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        float mouseY = Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        fpc.Rotate(Vector3.up * mouseX);
    }
}
