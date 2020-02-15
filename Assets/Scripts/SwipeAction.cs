using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeAction : MonoBehaviour
{
    private CubeRotateAction cubeRotateAction = new CubeRotateAction();

    public void SwipedLeft(GameObject mainCube, GameObject ghostCube, float time)
    {
        cubeRotateAction.RotateLeft(ghostCube);

        StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, time));
    }

    public void SwipedRight(GameObject mainCube, GameObject ghostCube, float time)
    {
        cubeRotateAction.RotateRight(ghostCube);

        StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, time));
    }

    public void SwipedUp(GameObject mainCube, GameObject ghostCube, float time)
    {
        cubeRotateAction.RotateForward(ghostCube);

        StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, time));
    }

    public void SwipedDown(GameObject mainCube, GameObject ghostCube, float time)
    {
        cubeRotateAction.RotateBackward(ghostCube);

        StartCoroutine(cubeRotateAction.RotateLerp(mainCube, ghostCube.transform.rotation, time));
    }
}
