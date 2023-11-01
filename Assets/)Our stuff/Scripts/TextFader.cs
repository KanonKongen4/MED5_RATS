using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextFader : MonoBehaviour
{
    public TextMeshPro textToFade;
    public float timeBeforeFade = 2;
    public float fadeSpeed = 0.006f;

    public XRIDefaultInputActions inputActions;

    public bool AutoStart = true;

    //private void Awake()
    //{
    //    inputActions = new XRIDefaultInputActions();
    //}
    //private void OnEnable()
    //{
    //    inputActions.XRILeftHandInteraction.Select.started += context => StartFadeIn();
    //    inputActions.XRILeftHandInteraction.Select.Enable();
    //    inputActions.XRIRightHandInteraction.Select.started += context => StartFadeIn();
    //    inputActions.XRIRightHandInteraction.Select.Enable();
    //    inputActions.XRILeftHandLocomotion.Move.Enable();
    //    inputActions.XRILeftHandLocomotion.Turn.Enable();
    //}
  

    void Start()
    {
        textToFade = GetComponent<TextMeshPro>();
        textToFade.alpha = 0;
        if(AutoStart)
        StartCoroutine(Fader(timeBeforeFade));

    }
    private IEnumerator Fader(float timeBeforeFade)
    {
        yield return new WaitForSeconds(timeBeforeFade);

        while (textToFade.alpha < 1)
        {
            textToFade.alpha += fadeSpeed;
            yield return null;
        }
    }

    public void StartFadeIn()
    {
        StartCoroutine(Fader(timeBeforeFade));

    }

}
