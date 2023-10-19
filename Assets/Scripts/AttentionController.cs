using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttentionController : MonoBehaviour
{
    public Interface_AttentionMethod attentionMethod; // this finds the first class which uses the interface. So the first attention method class is selected here.
    public InputActionReference inputactionReference;
    public GameObject currentTarget;
    public int currentTargetID = 0;
    public GameObject previousTarget;

    public List<GameObject> targets;

    void Start()
    {
        attentionMethod = GetComponent<Interface_AttentionMethod>();

        foreach (GameObject gm in GameObject.FindGameObjectsWithTag("Target"))
        {
            targets.Add(gm);
        }
        SetStartTarget();
        Invoke("ChangeTarget", 4);
    }
    private void SetStartTarget()
    {
        currentTarget = targets[0];
        previousTarget = targets[0];
        attentionMethod.DoMethod(currentTarget);
    }
    public void ChangeTarget()
    {
        if (currentTargetID == targets.Count) return; //"Guard clause" the below code won't run if the last target has been reached.

        currentTargetID++;
        currentTarget = targets[currentTargetID];
        previousTarget = currentTarget;

        attentionMethod.DoMethod(currentTarget);
    }
}
