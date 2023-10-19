using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttentionMethod_Saturation : MonoBehaviour,  Interface_AttentionMethod
{
    private byte overlayLayer = 6;

    public void DoMethod(GameObject objectToAddAttentionTo)
    {
        ChangeLayers(objectToAddAttentionTo);
    }
    private void ChangeLayers(/*GameObject setAsDefault,*/ GameObject setAsOverlay)
    {

        //setAsDefault.layer = 0; //Default layer
        //setAsDefault = setAsOverlay;
        setAsOverlay.layer = overlayLayer;

        Debug.Log("did the layer thing");
    }
}
