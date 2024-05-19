using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopSelf : ClickableBase // INHERITANCE
{
    private Rigidbody thisRigidbody;
    private float upwardPower = 10;

    private void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        AddUpwardForce();
    }

    private void AddUpwardForce() // ABSTRACTION
    {
        thisRigidbody.AddForce(Vector3.up * upwardPower, ForceMode.Impulse);
    }
}
