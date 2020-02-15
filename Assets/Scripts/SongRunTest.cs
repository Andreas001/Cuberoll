using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongRunTest : MonoBehaviour
{
    public GameObject conductor;

    public GameObject test;

    Vector3 newVec;

    void Update()
    {
        newVec = new Vector3(test.transform.position.x, test.transform.position.y, -conductor.GetComponent<Conductor>().GetBeatPosition());

        test.transform.position = newVec;
    }
}
