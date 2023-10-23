using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class AM_Saturation : MonoBehaviour,  Interface_AttentionMethod
{
    private byte overlayLayer = 6;
    public VolumeProfile volumeProfile;


    public void DoMethod(GameObject objectToAddAttentionTo)
    {
        ChangeLayers(objectToAddAttentionTo);
        //  volumeProfile.weight = 1;

        // You can leave this variable out of your function, so you can reuse it throughout your class.
        UnityEngine.Rendering.Universal.ColorAdjustments colorAdjustments;

        if (!volumeProfile.TryGet(out colorAdjustments)) throw new System.NullReferenceException(nameof(colorAdjustments));

        colorAdjustments.saturation.Override(-100.0f);
    }
    private void ChangeLayers(/*GameObject setAsDefault,*/ GameObject setAsOverlay)
    {

        //setAsDefault.layer = 0; //Default layer
        //setAsDefault = setAsOverlay;
        setAsOverlay.layer = overlayLayer;

        Debug.Log("did the layer thing");
    }
}
