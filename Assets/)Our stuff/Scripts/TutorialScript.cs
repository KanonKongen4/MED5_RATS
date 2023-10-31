using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using System;
using static System.Net.Mime.MediaTypeNames;

public class TutorialScript : MonoBehaviour //After 2 seconds, show floating text controls. And when the corresponding keys are pressed,
    //Delete the text after the button is pressed. Also change the text to green, make it not a child anymore and gradually fade it out.:p
{

    //TODO: rewrite this & DrawLineToObjects
    public TextMeshPro text_joystickLeft, text_bumperLeft, text_joystickRight, text_bumperRight;
    public bool ableToMakeControlsDisappear;
    public bool rightContoller;

    public XRIDefaultInputActions inputActions;

    private Vector2 playerMovement, playerRotation;

    private void Awake()
    {
        inputActions = new XRIDefaultInputActions();
    }
    void Start()
    {
        ShowControlsAfterSeconds(4);
    }

    private void Update()
    {
        if (rightContoller)
        {
            playerRotation = inputActions.XRIRightHandLocomotion.Turn.ReadValue<Vector2>();
            if (playerRotation != Vector2.zero)
                text_joystickRight.color = Color.green;
            else
                text_joystickRight.color = Color.white;
        }
        else
        {
            playerMovement = inputActions.XRILeftHandLocomotion.Move.ReadValue<Vector2>();
            if (playerMovement != Vector2.zero)
                text_joystickLeft.color = Color.green;
            else
                text_joystickLeft.color = Color.white;
        }
    }

    private void OnEnable()
    {
        inputActions.XRILeftHandInteraction.Select.performed += context => HideForceGrabText();
        inputActions.XRILeftHandInteraction.Select.Enable();
        inputActions.XRIRightHandInteraction.Select.performed += context => HideNormalGrabText();
        inputActions.XRIRightHandInteraction.Select.Enable();
        inputActions.XRILeftHandLocomotion.Move.Enable();
        inputActions.XRIRightHandLocomotion.Turn.Enable();
    }

    private void ShowControlsAfterSeconds(int seconds)
    {
        //if(rightContoller)
        //{
        //    text_joystickRight.gameObject.SetActive(true);
        //}
        //else
        //{
        //    text_joystickLeft.gameObject.SetActive(true);
        //    fttext_bumperLeft.gameObject.SetActive(true);
        //}

        Invoke(nameof(MakeControlsAbleToDisappear), 1);
    }

    //public void HideWalkText()
    //{
    //    HideText(text_joystickLeft);
    //}
    public void HideForceGrabText()
    {
        HideText(text_bumperLeft);
    }
    public void HideNormalGrabText()
    {
        HideText(text_bumperRight);
    }
    //public void HideRotateText()
    //{
    //    HideText(text_joystickRight);
    //}
    private void MakeControlsAbleToDisappear()
    {
        ableToMakeControlsDisappear = true;
    }
    private void HideText(TextMeshPro text)
    {
        if (text == null) return;
        text.GetComponent<DrawLineToObject>().InvokeMe();
        //text.transform.parent = transform.root;
        //Destroy(text,4);
    }
}
