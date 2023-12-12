using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Playables;

public class TimelineMng : MonoBehaviour
{
    private Animator[] animators;
    private PlayableDirector director;
    public InputActionReference selectAction;
    bool timelineRunning = false;
    
    private void Start()
    {
        director = GetComponent<PlayableDirector>();
        animators = FindObjectsOfType<Animator>();
        director.Pause();

        for (int i = 0; i < animators.Length; i++)
        {
            animators[i].enabled = false;
        }
    }

    private void Update()
    {
        if (timelineRunning)
        {
            return;
        }
        float butDown = selectAction.action.ReadValue<float>();
        if (butDown > .9f)
        {
            Debug.Log(butDown);
            BeginTimeline();
            timelineRunning = true;
        }
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
