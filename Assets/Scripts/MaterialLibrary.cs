using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialLibrary : MonoBehaviour
{
    public Material red;
    public Material yellow;
    public Material green;
    public Material cyan;
    public Material purple;
    public Material black;

    public Material GetRed()
    {
        return red;
    }

    public Material GetYellow()
    {
        return yellow;
    }

    public Material GetGreen()
    {
        return green;
    }

    public Material GetCyan()
    {
        return cyan;
    }

    public Material GetPurple()
    {
        return purple;
    }

    public Material GetBlack()
    {
        return black;
    }
}
