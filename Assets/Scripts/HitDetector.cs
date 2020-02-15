using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public GameObject player;

    public string color;

    void OnTriggerEnter(Collider collider)
    {
        player.GetComponent<Player>().Hit(collider.gameObject, color);

        collider.gameObject.SetActive(false);
    }
}
