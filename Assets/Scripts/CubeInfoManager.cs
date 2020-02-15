using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeInfoManager : MonoBehaviour
{
    public GameObject frontObjectImage;
    public GameObject bottomObjectImage;

    public Sprite Red;
    public Sprite Yellow;
    public Sprite Green;
    public Sprite Cyan;
    public Sprite Purple;
    public Sprite Black;

    public void ChangeColor(string image, string color)
    {
        GameObject n; ;

        if (image.Equals("front"))
        {
            n = frontObjectImage;
        }
        else
        {
            n = bottomObjectImage;
        }

        if (color.Equals("red"))
        {
            n.GetComponent<Image>().sprite = Red;
        }
        else if (color.Equals("yellow"))
        {
            n.GetComponent<Image>().sprite = Yellow;
        }
        else if (color.Equals("green"))
        {
            n.GetComponent<Image>().sprite = Green;
        }
        else if (color.Equals("cyan"))
        {
            n.GetComponent<Image>().sprite = Cyan;
        }
        else if (color.Equals("purple"))
        {
            n.GetComponent<Image>().sprite = Purple;
        }
        else if (color.Equals("black"))
        {
            n.GetComponent<Image>().sprite = Black;
        }
    }
}
