using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BodyPartController : MonoBehaviour
{
    public Vector3 firstPos;
    public Vector3 startPos;

    public float moveVal;
    public float speed;

    private void Start()
    {
         startPos = transform.localPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
        }
    }

    public void ReturnPos()
    {
        transform.DOLocalMove(startPos,speed).SetEase(Ease.OutBounce);
    }

    public void firstMove()
    {
        transform.DOLocalMove(new Vector3(transform.localPosition.x+moveVal,transform.localPosition.y,firstPos.z), speed);
    }

    
    
    
    
}
