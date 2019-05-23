using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AngularTweeks  
{
    public static float AngleOffset(ForwardSide forwardSide)
    {
        float _angularOffset = 0f;

        switch (forwardSide)
        {
            case ForwardSide.Top:
                _angularOffset = 90f;
                break;

            case ForwardSide.Right:
                _angularOffset = 0f;
                break;

            case ForwardSide.Buttom:
                _angularOffset = 270f;
                break;

            case ForwardSide.Left:
                _angularOffset = 180f;
                break;

        }

        return _angularOffset;
    }

    public static Vector3 DirectionOffset(ForwardSide forwardSide)
    {
        Vector3 _dirOffset = Vector3.zero;

        switch (forwardSide)
        {
            case ForwardSide.Top:
                _dirOffset = Vector3.up;
                break;

            case ForwardSide.Right:
                _dirOffset = Vector3.right;
                break;

            case ForwardSide.Buttom:
                _dirOffset = Vector3.down;
                break;

            case ForwardSide.Left:
                _dirOffset = Vector3.left;
                break;


        }

        return _dirOffset;
    }
}


public enum ForwardSide
{
    Top,
    Right,
    Buttom,
    Left
}
