using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpinningShape : Shape
{
    private void Start()
    {
        ShapeName = "Spinning Cube";
    }

    public override void SelectShape()
    {
        Debug.Log("SpinningSelected");
        base.SelectShape();
    }

    public override void TransformShape()
    {
        Debug.Log("Transforming Spinning Shape");
        transform.Rotate(Vector3.up);
    }

}
