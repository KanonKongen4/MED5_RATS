using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScenechange : MonoBehaviour
{
    // Start is called before the first frame update
    private SceneChanger sceneChanger;
    public int changeTo = 0;
    void Start()
    {
        sceneChanger = FindObjectOfType<SceneChanger>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key to Door")
        { 
            sceneChanger.sceneID = changeTo;
            sceneChanger.InitiateSceneChange();
        }
    }
}
