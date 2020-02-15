using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject oneText;
    public GameObject twoText;
    public GameObject threeText;

    public void one()
    {
        oneText.SetActive(true);
        twoText.SetActive(false);
        threeText.SetActive(false);
    }

    public void two()
    {
        oneText.SetActive(false);
        twoText.SetActive(true);
        threeText.SetActive(false);
    }

    public void three()
    {
        oneText.SetActive(false);
        twoText.SetActive(false);
        threeText.SetActive(true);
    }
}
