using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BodyCut : MonoBehaviour
{
    public List<BodyPartController> bodyParts = new List<BodyPartController>();
    public GameObject a, b, c, d;
    public GameObject organ;

    public GameObject z, x, s;
    public GameObject uncut1, uncut2, uncut3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            FirstTrigPoint();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SecTrigPoint();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ThirdTrigPoint();
        }
    }

    public void FirstTrigPoint()
    {
        bodyParts[0].firstMove();
        bodyParts[1].firstMove();
        a.SetActive(false);
    }

    public void SecTrigPoint()
    {
        bodyParts[0].firstMove();
        bodyParts[1].firstMove();
        bodyParts[2].firstMove();
        bodyParts[3].firstMove();
        b.SetActive(false);
    }

    public void ThirdTrigPoint()
    {
        bodyParts[0].firstMove();
        bodyParts[1].firstMove();
        bodyParts[2].firstMove();
        bodyParts[3].firstMove();
        bodyParts[4].firstMove();
        bodyParts[5].firstMove();
        c.SetActive(false);
    }

    public void CutOrgan()
    {
        d.SetActive(false);
        organ.GetComponent<Rigidbody>().isKinematic = false;
        organ.GetComponent<XRGrabInteractable>().enabled = true;
        s.SetActive(true);
        z.SetActive(true);
        x.SetActive(true);
    }

    public void CutZ()
    {
        z.SetActive(false);
        uncut1.SetActive(true);
        bodyParts[0].ReturnPos();
        bodyParts[1].ReturnPos();
    }

    public void CutX()
    {
        x.SetActive(false);
        uncut2.SetActive(true);

        bodyParts[2].ReturnPos();
        bodyParts[3].ReturnPos();
    }

    public void CutS()
    {
        s.SetActive(false);
        uncut3.SetActive(true);
        bodyParts[4].ReturnPos();
        bodyParts[5].ReturnPos();
    }
}