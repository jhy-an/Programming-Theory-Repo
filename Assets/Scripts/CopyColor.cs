using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyColor : ChangeSelfColor // INHERITANCE
{
    [SerializeField] private MeshRenderer targetRenderer;

    protected override void OnMouseDown() // POLYMORPHISM
    {
        CopyTargetColor();
    }

    private void CopyTargetColor() // ABSTRACTION
    {
        thisMaterial.color = targetRenderer.material.color;
    }
}
