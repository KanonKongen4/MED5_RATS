using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class AM_Saturation : MonoBehaviour, Interface_AttentionMethod
{
    private byte overlayLayer = 6;
    public VolumeProfile volumeProfile;

    private Volume volume;
    private UnityEngine.Rendering.Universal.ColorAdjustments colorAdjustments;

    private void Awake()
    {
        volume = Camera.main.GetComponent<Volume>();
        ResetSaturation();
    }

    public void DoMethod(GameObject objectToAddAttentionTo)
    {
        ChangeLayers(objectToAddAttentionTo);
        //  volumeProfile.weight = 1;

        // You can leave this variable out of your function, so you can reuse it throughout your class.

        if (!volumeProfile.TryGet(out colorAdjustments)) throw new System.NullReferenceException(nameof(colorAdjustments));

        StartCoroutine(GradualChange());
    }
    private void ChangeLayers(GameObject setAsOverlay)
    {
        setAsOverlay.layer = overlayLayer;
        foreach (Transform child in setAsOverlay.transform)
        {
            child.gameObject.layer = overlayLayer;
        }
    }

    private void ResetSaturation()
    {
        if (!volumeProfile.TryGet(out colorAdjustments)) throw new System.NullReferenceException(nameof(colorAdjustments));

        colorAdjustments.saturation.Override(0.0f);
    }

    private IEnumerator GradualChange()
    {
        float currentSaturation = colorAdjustments.saturation.value;
        while (currentSaturation>-100f)
        {
            currentSaturation -= 1f;
            colorAdjustments.saturation.Override(currentSaturation);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
