using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AM_Saturation : MonoBehaviour,  Interface_AttentionMethod
{
    private byte overlayLayer = 6;
    public Volume volume;


    public void DoMethod(GameObject objectToAddAttentionTo)
    {
        ChangeLayers(objectToAddAttentionTo);
        volume.weight = 1;
    }
    private void ChangeLayers(/*GameObject setAsDefault,*/ GameObject setAsOverlay)
    {

        //setAsDefault.layer = 0; //Default layer
        //setAsDefault = setAsOverlay;
        setAsOverlay.layer = overlayLayer;

        Debug.Log("did the layer thing");
    }
}
