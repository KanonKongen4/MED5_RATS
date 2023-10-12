using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttentionController : MonoBehaviour
{
    private byte overlayLayer = 6;

    public InputActionReference inputactionReference;
    public GameObject currentTarget;
    public GameObject previousTarget;

    public List<GameObject> targets;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gm in GameObject.FindGameObjectsWithTag("Target"))
        {
            targets.Add(gm);
        }
    }
    //private void OnEnable()
    //{
        
    //}

    public void ChangeTarget()
    {
        Debug.Log("chaaaaange targets");
        int ranNum = Random.Range(0, targets.Count);
        currentTarget = targets[ranNum];
    }
    public void ChangeLayers()
    {

        previousTarget.layer = 0; //Default layer
        previousTarget = currentTarget;
        currentTarget.layer = overlayLayer;

        Debug.Log("did the layer thing");
    }
 
}
