using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScale : MonoBehaviour
{
    Vector3 scale;

    void Awake()
    {
        scale = transform.localScale;
        //GameObject LockSize = GameObject.Find("LockSize");
        //StickyBall size = LockSize.GetComponent<StickyBall>;


    }
    void LateUpdate()
    {
        transform.localScale = scale;
        ////transform.localscale = scale
    }
}
