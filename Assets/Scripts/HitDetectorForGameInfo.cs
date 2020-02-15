using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetectorForGameInfo : MonoBehaviour
{
    public GameObject manager;

    public string image;

    void OnTriggerEnter(Collider collider)
    {
        manager.GetComponent<CubeInfoManager>().ChangeColor(image, collider.GetComponent<GhostCubeDetector>().GetColor());
    }
}
