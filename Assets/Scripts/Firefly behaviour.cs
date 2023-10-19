using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflybehaviour : MonoBehaviour, Interface_AttentionMethod
{
    public float speed = 1f;
    Vector3 startPosition;
    Vector3 endPosition;

    private void Start()
    {
        startPosition = gameObject.transform.position;
        endPosition = gameObject.transform.position;
    }

    // Start is called before the first frame update
    public void DoMethod (GameObject target)
    {
        startPosition = gameObject.transform.position;
        endPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, Time.deltaTime * speed);
    }
}
