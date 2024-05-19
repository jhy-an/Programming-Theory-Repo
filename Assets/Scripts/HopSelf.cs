using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopSelf : ClickableBase
{
    private Rigidbody thisRigidbody;
    private float upwardPower = 10;

    private void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    protected override void OnMouseDown()
    {
        AddUpwardForce();
    }

    private void AddUpwardForce()
    {
        thisRigidbody.AddForce(Vector3.up * upwardPower, ForceMode.Impulse);
    }
}
