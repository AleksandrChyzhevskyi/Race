using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folov : MonoBehaviour
{
    public Transform Target, SelfTransform;
       
    void LateUpdate()
    {
        SelfTransform.position = Vector3.Lerp(SelfTransform.position, Target.position + new Vector3 (0, 0, -2), 0.5f);
    }
}
