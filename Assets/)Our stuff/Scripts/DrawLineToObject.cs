using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineToObject : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform target;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, target.position);
    }
}
