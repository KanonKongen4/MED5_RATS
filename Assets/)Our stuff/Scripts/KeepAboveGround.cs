using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAboveGround : MonoBehaviour
{
    public Transform mainCamTransform;
    private void Start()
    {
        mainCamTransform = Camera.main.transform;
    }
    private void FixedUpdate()
    {
        if(transform.position.y < 0)
        {
            transform.position = new Vector3(mainCamTransform.position.x, 1, mainCamTransform.position.z);
        }
    }
}
