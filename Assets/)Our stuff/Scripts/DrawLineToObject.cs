using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DrawLineToObject : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform target;
    private TextMeshPro connectedText;
    private float lineLengthMultiplier = 0.8f;

    private IEnumerator ColorSetter;
    public float widthToAdd = 0f;

    void Start()
    {
        //ColorSetter = SetColorBack();
        

        lineRenderer = GetComponent<LineRenderer>();
        connectedText = GetComponent<TextMeshPro>();
        lineRenderer.widthMultiplier = 0;
    }

    void Update()
    {
        lineRenderer.widthMultiplier = ((connectedText.alpha/255)/1.5f)+(widthToAdd*(connectedText.alpha/255)); 
        lineRenderer.SetPosition(0, target.position);
        lineRenderer.SetPosition(1, target.position - (target.position - transform.GetComponent<Renderer>().bounds.center) * lineLengthMultiplier);
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
