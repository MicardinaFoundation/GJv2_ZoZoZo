using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * moveSpeed, 0);
    }
}
