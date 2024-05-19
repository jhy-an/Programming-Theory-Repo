using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSelfColor : ClickableBase // INHERITANCE
{
    protected Material thisMaterial;
    public Color color { get => thisMaterial.color; } // ENCAPSULATION

    private void Start()
    {
        thisMaterial = GetComponent<MeshRenderer>().material;
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        ChangeColor();
    }

    private void ChangeColor() // ABSTRACTION
    {
        thisMaterial.color = Random.ColorHSV();
    }
}
