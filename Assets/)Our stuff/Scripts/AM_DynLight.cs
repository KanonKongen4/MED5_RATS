using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AM_DynLight : MonoBehaviour, Interface_AttentionMethod
{
    public GameObject target;
    public Transform lightTransform;
    private Vector3 lookVector;
    public bool useSmoothRotation;
    public float rotationSpeed = 1f;
    public void DoMethod(GameObject target)
    {
        this.target = target;
    }

    void Update()
    {
        if (target == null) return; //So below is not run if target is null..


        if (!useSmoothRotation)
            lightTransform.LookAt(target.GetComponent<Renderer>().bounds.center);
        else
        {
            lookVector = ( target.GetComponent<Renderer>().bounds.center-lightTransform.position).normalized; // find direction & normalize vector so max length is 1. So just direction
            lightTransform.rotation = Quaternion.Lerp(Quaternion.LookRotation(lightTransform.transform.forward), Quaternion.LookRotation(lookVector), Time.deltaTime * rotationSpeed);
        }
    }
}