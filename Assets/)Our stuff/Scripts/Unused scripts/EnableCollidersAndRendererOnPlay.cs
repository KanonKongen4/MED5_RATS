using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCollidersAndRendererOnPlay : MonoBehaviour
{

    void Start()
    {
        if (GetComponent<MeshRenderer>() != null)
            GetComponent<MeshRenderer>().enabled = true;
        if (GetComponent<BoxCollider>() != null)
            GetComponent<BoxCollider>().enabled = true;
        if (GetComponent<SphereCollider>() != null)
            GetComponent<SphereCollider>().enabled = true;
        if (GetComponent<MeshCollider>() != null)
            GetComponent<MeshCollider>().enabled = true;

    }

}
