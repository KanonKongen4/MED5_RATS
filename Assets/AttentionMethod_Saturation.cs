using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttentionMethod_Saturation : Interface_AttentionMethod
{
    private static byte overlayLayer = 6;

    public void DoMethod()
    {

    }
    public static void ChangeLayers(GameObject setAsDefault, GameObject setAsOverlay)
    {

        setAsDefault.layer = 0; //Default layer
        setAsDefault = setAsOverlay;
        setAsOverlay.layer = overlayLayer;

        Debug.Log("did the layer thing");
    }
}
