using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwipeManager : MonoBehaviour
{
    public CubeRotateAction cubeRotateAction;

    public GameObject mainCube;
    public GameObject ghostCube;

    public float timer = 0.0f;

    public int rotateTime = 1;
    public float rotateSpeed = 0.8f;

    public bool rotating = false;

    //Debug

    public GameObject textDebug;

    private void Start()
    {
        cubeRotateAction = new CubeRotateAction();
    }

    void Update()
    {
        if (rotating)
        {
            textDebug.GetComponent<GameDebug>().UpdateTextToNo();
        }
        else if (!rotating)
        {
            textDebug.GetComponent<GameDebug>().UpdateTextToYes();
        }
    }

    void FixedUpdate()
    {
        if (rotating)
        {
            timer += Time.deltaTime;
            int seconds = Convert.ToInt32(timer % 60);

            if (seconds >= rotateTime)
            {
                rotating = false;
                timer = 0.0f;
            }
        }
    }

    public void SwipedLeft()
    {
        if (rotating)
        {
            Debug.Log("Still Rotating");
        }
        else
        {
            rotating = true;

            cubeRotateAction.RotateLeft(ghostCube);

            StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, rotateSpeed));
        }
    }

    public void SwipedRight()
    {
        if (rotating)
        {
            Debug.Log("Still Rotating");
        }
        else
        {
            rotating = true;

            cubeRotateAction.RotateRight(ghostCube);

            StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, rotateSpeed));
        }
    }

    public void SwipedUp()
    {
        if (rotating)
        {
            Debug.Log("Still Rotating");
        }
        else
        {
            rotating = true;

            cubeRotateAction.RotateForward(ghostCube);

            StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, rotateSpeed));
        }
    }

    public void SwipedDown()
    {
        if (rotating)
        {
            Debug.Log("Still Rotating");
        }
        else
        {
            rotating = true;

            cubeRotateAction.RotateBackward(ghostCube);

            StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, rotateSpeed));
        }
    }
}
