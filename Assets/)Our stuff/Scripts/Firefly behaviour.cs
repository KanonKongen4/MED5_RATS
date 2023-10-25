using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflybehaviour : MonoBehaviour, Interface_AttentionMethod
{
    public GameObject fireflyObj;
    public float speed = 1f;
    
    Vector3 startPosition;
    Vector3 endPosition;

    private void Awake()
    {
        startPosition = fireflyObj.transform.position;
        endPosition = fireflyObj.transform.position;
    }

    // Start is called before the first frame update
    public void DoMethod (GameObject target)
    {
        Debug.Log("Firefly go!");
        startPosition = fireflyObj.transform.position;
        if (target.GetComponent<Renderer>() != null)
        {
            Debug.Log("End = center");
            endPosition = target.GetComponent<Renderer>().bounds.center;
        }
        else
        {
            Debug.Log("End != center");
            endPosition = target.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        fireflyObj.transform.position = Vector3.Lerp(fireflyObj.transform.position, endPosition, Time.deltaTime * speed);
    }
}
