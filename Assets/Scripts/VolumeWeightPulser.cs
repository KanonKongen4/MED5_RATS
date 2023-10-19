using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeWeightPulser : MonoBehaviour
{
    public Volume volume;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volume.weight = Mathf.Sin(Time.time/2);
    }
}
