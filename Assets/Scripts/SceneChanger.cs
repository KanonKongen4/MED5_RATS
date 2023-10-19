using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    private IEnumerator opacityFaderIn, opacityFaderOut;
    private CanvasGroup blackFadeCanvasGroup;
    public int sceneID;
    public int fadeTime = 2, sceneChangeDelay;
    void Start()
    {
        blackFadeCanvasGroup = GetComponentInChildren<CanvasGroup>();
        opacityFaderIn = OpacityFader(fadeTime, 1);
        opacityFaderOut = OpacityFader(fadeTime, 0);
        blackFadeCanvasGroup.alpha = 1f;
        StartCoroutine(opacityFaderOut); // When scene starts, remove the black Image

        //Invoke(nameof(InitiateSceneChange),4);
    }

    public void InitiateSceneChange()
    {
        Debug.Log("startscene cahnge");

        StartCoroutine(opacityFaderIn);
        StartCoroutine(nameof(LoadScene),fadeTime + sceneChangeDelay);
    }
   
    private IEnumerator OpacityFader(float timeToFade, float target)
    {
        var currentOpacity = blackFadeCanvasGroup.alpha; // Get the current opacity from the canvasgroup component
        while (currentOpacity!= target) // if the current opacity has not reached target...
        {
            currentOpacity = Mathf.MoveTowards(currentOpacity, target, Time.deltaTime/timeToFade); // Mathf.MoveTowards automatically increments/decrements current
            //Opacity towards the target. Time.deltaTime is divided by the timeToFade to get the tiny opacity change needed in the following frames to achieve the target opacity in 2 seconds
            blackFadeCanvasGroup.alpha = currentOpacity;
            yield return 0;
        }
    }

    private IEnumerator LoadScene(float timeBeforeLoad)
    {
        Debug.Log("start load in 2 seoncds");
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene(sceneID);
    }
}
