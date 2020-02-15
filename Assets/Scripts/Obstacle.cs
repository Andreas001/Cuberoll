using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public string color;
    public Material material;

    public GameObject manager;
    public MaterialLibrary library;

    void Start()
    {
        library = manager.GetComponent<MaterialLibrary>();
    }

    public void RandomizeColor()
    {
        float randomValue = Random.value;

        if (randomValue < .15f)
        {
            color = "red";
            material = library.GetRed();
        }
        else if (randomValue < .30f)
        {
            color = "green";
            material = library.GetGreen();
        }
        else if (randomValue < .45f)
        {
            color = "yellow";
            material = library.GetYellow();
        }
        else if (randomValue < .60f)
        {
            color = "cyan";
            material = library.GetCyan();
        }
        else if (randomValue < .75f)
        {
            color = "purple";
            material = library.GetPurple();
        }
        else if (randomValue < .90f)
        {
            color = "black";
            material = library.GetBlack();
        }
        else
        {
            color = "purple";
            material = library.GetPurple();
        }

        this.transform.GetChild(0).GetComponent<Renderer>().material = material;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetActive()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SetDisabled()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
