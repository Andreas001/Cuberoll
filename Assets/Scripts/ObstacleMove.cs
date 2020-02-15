using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public GameObject player;

    Vector3 startPosition;

    public float speed = 10f;

    public bool move = false;

    void Start()
    {
        startPosition = this.transform.position;
    }

    void FixedUpdate()
    {
        if (move)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, Time.deltaTime * speed);
        }
    }

    public void SetMoveBool(bool status)
    {
        this.move = status;
    }
}
