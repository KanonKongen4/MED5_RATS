using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_pickup : MonoBehaviour
{
    public AttentionController attentionController;
    public byte nextTargetID = 1;

    private void Start()
    {
        attentionController = FindObjectOfType<AttentionController>();
    }
    public void SetNextTarget()
    {
        attentionController.ChangeTargetByID (nextTargetID);
    }
}
