using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;
using UnityEngine.XR.OpenXR.Input;

public class TimelineMng : MonoBehaviour
{
    private Animator[] animators;
    private PlayableDirector director;
    public XRController rController;

    private void Start()
    {
        director = GetComponent<PlayableDirector>();
        animators = FindObjectsOfType<Animator>();
        director.Pause();
    }

    private void Update()
    {
    }

    public void BeginTimeline()
    {
        for (int i = 0; i < animators.Length; i++)
        {
            animators[i].enabled = true;
        }
        director.Play();
    }
}
