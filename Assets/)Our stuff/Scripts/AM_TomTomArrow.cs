using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AM_TomTomArrow : MonoBehaviour, Interface_AttentionMethod
{
    public GameObject tomTomArrow;
    public GameObject target;

    public void DoMethod(GameObject target)
    {
        this.target = target;
    }
    private void Update()
    {
        tomTomArrow.transform.LookAt(target.transform);
    }
}
