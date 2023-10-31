using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DrawLineToObject : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform target;
    private TextMeshPro connectedText;
    private float lineLengthMultiplier = 0.7f;

    private IEnumerator ColorSetter;

    void Start()
    {
        //ColorSetter = SetColorBack();

        lineRenderer = GetComponent<LineRenderer>();
        connectedText = GetComponent<TextMeshPro>();
        lineRenderer.widthMultiplier = 0;
    }

    void Update()
    {
        lineRenderer.widthMultiplier = connectedText.alpha/255; 
        lineRenderer.SetPosition(0, target.position);
        lineRenderer.SetPosition(1, target.position - (target.position - transform.position) * lineLengthMultiplier);
    }
    public void InvokeMe()
    {
        StartCoroutine(SetColorBack()) ;

    }
    private IEnumerator SetColorBack()
    {
        connectedText.color = Color.green;

        yield return new WaitForSeconds(0.7f);
        connectedText.color = Color.white;

    }
}
