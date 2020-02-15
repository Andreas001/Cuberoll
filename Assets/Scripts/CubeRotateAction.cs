using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateAction : MonoBehaviour
{
    float rotSpeed = 20;

    float rotationX;
    float rotationY;

    public void RotateLeft(GameObject objectToRotate)
    {
        rotationY = 90f * Mathf.Deg2Rad;

        objectToRotate.transform.RotateAround(Vector3.up, rotationY);
    }

    public void RotateRight(GameObject objectToRotate)
    {
        rotationY = -90f * Mathf.Deg2Rad;

        objectToRotate.transform.RotateAround(Vector3.up, rotationY);
    }

    public void RotateForward(GameObject objectToRotate)
    {
        rotationX = 90f * Mathf.Deg2Rad;

        objectToRotate.transform.RotateAround(Vector3.right, rotationX);
    }

    public void RotateBackward(GameObject objectToRotate)
    {
        rotationX = -90f * Mathf.Deg2Rad;

        objectToRotate.transform.RotateAround(Vector3.right, rotationX);
    }

    public IEnumerator RotateLerp(GameObject objectToRotate, Quaternion newRotation, float inTime)
    {
        var fromAngle = objectToRotate.transform.rotation;
        var toAngle = newRotation;

        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            objectToRotate.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);

            yield return null;
        }
        objectToRotate.transform.rotation = toAngle;
    }
}