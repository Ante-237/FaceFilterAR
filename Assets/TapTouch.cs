using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTouch : MonoBehaviour
{
    void OnEnable()
    {
        Lean.Touch.LeanTouch.OnFingerTap += HandleFingerTap;
    }

    void OnDisable()
    {
        Lean.Touch.LeanTouch.OnFingerTap -= HandleFingerTap;
    }

    void HandleFingerTap(Lean.Touch.LeanFinger finger)
    {
        Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);
    }
}