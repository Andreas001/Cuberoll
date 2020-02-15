using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveDebug : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject cube;

    Vector3 startPos;

    private float fraction = 0;

    public float speed = .01f;

    void Start()
    {
        startPos = obstacle.transform.position;
        //obstacle.transform.position = Vector3.MoveTowards(startPos, cube.transform.position, Time.deltaTime * speed);
    }

    void FixedUpdate()
    {
        obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, cube.transform.position, Time.deltaTime * speed);
    }

    void Update()
    {
        //obstacle.transform.position = Vector3.Lerp(startPos, cube.transform.position, fraction);
        //obstacle.transform.position = Vector3.MoveTowards(startPos, cube.transform.position, Time.deltaTime * speed);
    }
}
