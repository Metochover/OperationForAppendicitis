using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OpenRope : MonoBehaviour
{
    public float openRopeSpeed;
    private void Start()
    {
        transform.DOLocalRotate(Vector3.zero, openRopeSpeed);
    }
}
