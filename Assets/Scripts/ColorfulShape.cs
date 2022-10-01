using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorfulShape : Shape
{
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float speed = 1.0f;
    Renderer rend;

    private void Start()
    {
        ShapeName = "Colorful Sphere";
        rend = GetComponent<Renderer>();
    }


    public override void SelectShape()
    {
        Debug.Log("ColorfulSelected");
        base.SelectShape();
        
    }

    public override void TransformShape()
    {
        float lerp = (Mathf.Sin(Time.time * speed) + 1) / 2.0f;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }

}
