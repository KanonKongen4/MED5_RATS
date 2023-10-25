using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttentionController : MonoBehaviour
{
    public Interface_AttentionMethod attentionMethod; // this finds the first class which uses the interface. So the first attention method class is selected here.
    public int currentTargetID = 0;
    public GameObject currentTarget;
    public GameObject previousTarget;

    [Header("Add targets from the scene: the order decides when queues will be used")]
    public List<GameObject> targets;

    void Start()
    {
        attentionMethod = GetComponent<Interface_AttentionMethod>();

        Invoke(nameof(SetStartTarget),1); // A second goes by before the method is started

    }
    private void SetStartTarget()
    {
        currentTarget = targets[0];
        previousTarget = targets[0];
        if(attentionMethod != null) // Checking if there is an attentionMethod present...
        attentionMethod.DoMethod(currentTarget);
    }
    public void ChangeToNextTarget()
    {
        if (currentTargetID == targets.Count) return; //"Guard clause" the below code won't run if the last target has been reached.

        currentTargetID++;
        currentTarget = targets[currentTargetID];
        previousTarget = currentTarget;

        attentionMethod.DoMethod(currentTarget);
    }
    public void ChangeTargetByID(byte id)
    {

        currentTargetID = id;
        currentTarget = targets[currentTargetID];
        previousTarget = currentTarget;

        attentionMethod.DoMethod(currentTarget);
    }
}
