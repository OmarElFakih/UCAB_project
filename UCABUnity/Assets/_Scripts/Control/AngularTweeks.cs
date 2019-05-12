using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AngularTweeks  
{
    public static float AngleOffset(ForwardSide forwardSide)
    {
        float AngularOffset = 0f;

        switch (forwardSide)
        {
            case ForwardSide.Top:
                AngularOffset = 90f;
                break;

            case ForwardSide.Right:
                AngularOffset = 0f;
                break;

            case ForwardSide.Buttom:
                AngularOffset = 270f;
                break;

            case ForwardSide.Left:
                AngularOffset = 180f;
                break;

        }

        return AngularOffset;
    }
}


public enum ForwardSide
{
    Top,
    Right,
    Buttom,
    Left
}
