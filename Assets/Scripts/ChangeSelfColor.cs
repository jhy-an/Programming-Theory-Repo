using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSelfColor : ClickableBase
{
    protected Material thisMaterial;
    public Color color { get => thisMaterial.color; }

    private void Start()
    {
        thisMaterial = GetComponent<MeshRenderer>().material;
    }

    protected override void OnMouseDown()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        thisMaterial.color = Random.ColorHSV();
    }
}
