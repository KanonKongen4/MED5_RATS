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
        if (target == null) return;
        tomTomArrow.transform.LookAt(target.GetComponent<Renderer>().bounds.center);
    }
}
