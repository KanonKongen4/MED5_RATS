using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class VibrateScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float intensity = 0.01f;
    void Update()
    {

        transform.localPosition = intensity * new Vector3(
            Mathf.PerlinNoise(speed * Time.time, 1),
            Mathf.PerlinNoise(speed * Time.time, 2),
            Mathf.PerlinNoise(speed * Time.time, 3));
    }
}
