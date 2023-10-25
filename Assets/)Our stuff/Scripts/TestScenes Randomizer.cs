using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class TestScenesRandomizer : MonoBehaviour
{
    private List<int> sceneList = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        RandomizeScene();
    }


    private void OnLevelWasLoaded(int level)
    {
        RandomizeScene();
    }

    void RandomizeScene ()
    {
        if (sceneList.Count <= 0)
        {
            return;
        }
        DoorScenechange newDoor = FindObjectOfType<DoorScenechange>();
        int nextDoor = Random.Range(0, sceneList.Count);
        newDoor.changeTo = sceneList[nextDoor];
        sceneList.RemoveAt(nextDoor);
    }
}
