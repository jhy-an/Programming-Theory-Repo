using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateSelf : ClickableBase
{
    private void Update()
    {
        CheckBound();
    }

    private void CheckBound()
    {
        if (transform.position.y < -3) Destroy(gameObject);
    }

    protected override void OnMouseDown()
    {
        CloneSelf();
    }

    private void CloneSelf()
    {
        Instantiate(gameObject);
    }
}
