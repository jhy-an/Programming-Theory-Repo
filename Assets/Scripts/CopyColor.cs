using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyColor : ChangeSelfColor
{
    [SerializeField] private MeshRenderer targetRenderer;

    protected override void OnMouseDown()
    {
        CopyTargetColor();
    }

    private void CopyTargetColor()
    {
        thisMaterial.color = targetRenderer.material.color;
    }
}
