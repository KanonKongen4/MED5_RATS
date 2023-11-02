using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScenesRandomizer : MonoBehaviour
{
    private List<int> sceneList = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);
        RandomizeScene();
    }


    private void OnLevelWasLoaded(int level)
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            return;
        }
        RandomizeScene();
    }

    void RandomizeScene ()
    {
        DoorScenechange newDoor = FindObjectOfType<DoorScenechange>();
        if (sceneList.Count <= 0)
        {
            // Final scene
            newDoor.changeTo = 0;
            Destroy(gameObject);
            return;
        }
        
        int nextDoor = Random.Range(0, sceneList.Count);
        newDoor.changeTo = sceneList[nextDoor];
        sceneList.RemoveAt(nextDoor);
    }
}
