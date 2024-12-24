using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
   public GameObject center;
   public float radius;
   public BodyCut bdCut;
   
   private void OnDrawGizmos()
   {
       Gizmos.DrawWireSphere(center.transform.position, radius);
   }

   private void Update()
   {
       InterractBody();
   }

   public void InterractBody()
   {
      Collider[] hitColliders = Physics.OverlapSphere(center.transform.position, radius);
      foreach (var hitCollider in hitColliders)
      {
          if (hitCollider.GetComponent<CutInterract>())
          {
              if (hitCollider.GetComponent<CutInterract>().i == 0)
              {
                  bdCut.FirstTrigPoint();
              }
              if (hitCollider.GetComponent<CutInterract>().i == 1)
              {
                  bdCut.SecTrigPoint();
              }
              if (hitCollider.GetComponent<CutInterract>().i == 2)
              {
                  bdCut.ThirdTrigPoint();
              }
              if (hitCollider.GetComponent<CutInterract>().i == 3)
              {
                  bdCut.CutOrgan();
              }
          }
      }
   }
}
