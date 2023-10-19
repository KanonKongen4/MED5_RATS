using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttentionController : MonoBehaviour
{
    public AttentionMethod attentionMethod; 
    public InputActionReference inputactionReference;
    public GameObject currentTarget;
    public int currentTargetID = 0;
    public GameObject previousTarget;

    public List<GameObject> targets;

    void Start()
    {
        foreach (GameObject gm in GameObject.FindGameObjectsWithTag("Target"))
        {
            targets.Add(gm);
        }
    }
 
    public void ChangeTarget()
    {
        Debug.Log("chaaaaange targets");
        currentTargetID++;
        currentTarget = targets[currentTargetID];
        previousTarget = currentTarget;
    }
   
 
}
