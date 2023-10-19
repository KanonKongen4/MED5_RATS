using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectHighlighter : MonoBehaviour
{
    public GameObject objectToHighlight;
    public GameObject previousObject;
    public int activeLayerInt;
    public InputActionReference confirm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetLayers()
    {
        objectToHighlight.layer = activeLayerInt;
        Debug.Log("HEY!");

    }
    private void OnEnable()
    {
        confirm.action.started += Confirm;
    }

    private void Confirm(InputAction.CallbackContext obj)
    {
        SetLayers();
       // throw new NotImplementedException();
    }
}
