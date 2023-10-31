using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TutorialScript : MonoBehaviour //After 2 seconds, show floating text controls. And when the corresponding keys are pressed,
    //Delete the text after the button is pressed. Also change the text to green, make it not a child anymore and gradually fade it out.:p
{

    //TODO: rewrite this & DrawLineToObjects
    public TextMeshPro text_joystickLeft, text_bumber, text_joystickRight;
    public bool ableToMakeControlsDisappear;
    public bool rightContoller;
    
    void Start()
    {
        ShowControlsAfterSeconds(4);
    }

    private void ShowControlsAfterSeconds(int seconds)
    {
        if(rightContoller)
        {
            text_joystickRight.gameObject.SetActive(true);
        }
        else
        {
            text_joystickLeft.gameObject.SetActive(true);
            text_bumber.gameObject.SetActive(true);
        }

        Invoke(nameof(MakeControlsAbleToDisappear), 1);
    }

    public void HideWalkText()
    {
        HideText(text_joystickLeft);
    }
    public void HideGrabText()
    {
        HideText(text_bumber);
    }
    public void HideRotateText()
    {
        HideText(text_joystickRight);
    }
    private void MakeControlsAbleToDisappear()
    {
        ableToMakeControlsDisappear = true;
    }
    private void HideText(TextMeshPro text)
    {
        text.GetComponent<DrawLineToObject>().InvokeMe();
        text.color = Color.green;
        //text.transform.parent = transform.root;
        Destroy(text,4);
    }
}
