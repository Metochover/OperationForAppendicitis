using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
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
                if (hitCollider.GetComponent<CutInterract>().i == 4)
                {
                    bdCut.CutZ();
                }
                if (hitCollider.GetComponent<CutInterract>().i == 5)
                {
                    bdCut.CutX();
                }
                if (hitCollider.GetComponent<CutInterract>().i == 6)
                {
                    bdCut.CutS();
                }
                
            }
        }
    }
}
