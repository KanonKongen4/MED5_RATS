using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeNav : MonoBehaviour
{
    private Rigidbody rb;
    public Camera cameraVR;
    public float moveSpeed = 0.16f;
    public float rotateSpeed = 1f;
    public bool xMovement = true;
    public bool yMovement = false;
    public bool zMovement = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = 0, y = 0, z = 0;
        if (xMovement) x = cameraVR.transform.forward.x;
        if (yMovement) y = cameraVR.transform.forward.y;
        if (zMovement) z = cameraVR.transform.forward.z;
        Vector3 moveDirection = new Vector3(x, y, z);
        rb.AddForce(moveDirection * moveSpeed, ForceMode.VelocityChange);
        rb.transform.rotation = Quaternion.Lerp(rb.transform.rotation, Quaternion.LookRotation(moveDirection), rotateSpeed * Time.fixedDeltaTime);
    }
}
