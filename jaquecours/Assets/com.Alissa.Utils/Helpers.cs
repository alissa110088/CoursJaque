using UnityEngine;

public static class Helpers
{
    public static void ResetTransform(this Transform t)
    {
        t.localPosition= Vector3.zero;
        t.localEulerAngles= Vector3.zero;
        t.localScale= Vector3.one;
    }
}
