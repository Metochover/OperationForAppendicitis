using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ScissorsController : MonoBehaviour
{
    public Transform one, two;

    public Vector3 s, ss;

    public GameObject center;
    public float radius;


    private void Update()
    {
        InterractBody();
    }

    public void InterractBody()
    {
        Collider[] hitColliders = Physics.OverlapSphere(center.transform.position, radius);
        foreach (var hitCollider in hitColliders)
        {
            
            {
                if (hitCollider.GetComponent<Organ>())
                {
                    hitCollider.GetComponent<Rigidbody>().isKinematic = true;
                    openScissors();
                   hitCollider.transform.SetParent(this.transform);
                   hitCollider.transform.DOMove(center.transform.position, .2f);
                }
               
                
                
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(center.transform.position, radius);
    }
    public void openScissors()
    {
        one.DOLocalRotate(s,0.5f).SetEase(Ease.Linear);
        two.DOLocalRotate(ss,0.5f).SetEase(Ease.Linear);
    }
    
    
    public void CloseScissors()
    {
        one.DOLocalRotate(Vector3.zero, 0.5f).SetEase(Ease.Linear);
        two.DOLocalRotate(Vector3.zero,0.5f).SetEase(Ease.Linear);
    }
}
