using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDebug : MonoBehaviour
{
    public GameObject camera;
    public GameObject objectA;
    public GameObject objectB;
    public GameObject objectC;
    public bool rotateX = false;
    public bool rotateY = false;

    Vector3 newA;
    Vector3 newB;


    float rotX;
    float rotY;

    Quaternion startRotation;
    Quaternion targetRotation;
    float rotSpeed = 20;
    float timer = 0.0f;

    void Update()
    {
        if(rotateX || rotateY)
        {
            timer += Time.deltaTime;
            int seconds = Convert.ToInt32(timer % 60);

            

            if (seconds > 2.0f)
            {
                rotateX = false;
                rotateY = false;
            }
        }
        
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * 1f * Time.deltaTime);
    }

    void FixedUpdate()
    {
        /*if (rotateX)
        {
            

            rotateX = false;

            //transform.RotateAround(Vector3.up, -rotX);
            //transform.Rotate(transform.rotation.eulerAngles.x, rotX, transform.rotation.eulerAngles.z, Space.Self);

            //transform.rotation = Quaternion.Lerp(transform.rotation, newQ, Time.deltaTime * 10);

            //transform.RotateAround(new Vector3(0,0,0), Vector3.up, 30 * Time.deltaTime);

            //rotateX = false;
        }
        else if (rotateY)
        {
            transform.RotateAround(Vector3.right, rotY);
            rotateY = false ;
        }*/
        //rotX = -4.5f * rotSpeed * Mathf.Deg2Rad;
        //startRotation = transform.rotation;
        //targetRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotX, transform.rotation.eulerAngles.z);
    }

    public void SwipedLeft()
    {
        if (rotateX)
        {
            Debug.Log("Is still rotating");
        }
        else
        {
            Debug.Log("Swiped Left");

            //rotX = transform.rotation.eulerAngles.x;
            //rotY = transform.rotation.eulerAngles.y - 90;

            //StartCoroutine(Rotate(rotX, rotY, 0.8f));

            //float b = transform.rotation.eulerAngles.y - 90;

            targetRotation = transform.rotation;

            rotX = -90 * rotSpeed * Mathf.Deg2Rad;
            transform.Rotate(Vector3.up, rotX, Space.World);

            //targetRotation *= Quaternion.AngleAxis(rotX, Vector3.up);
            Debug.Log(targetRotation);
            //StartCoroutine(RotateA(targetRotation, 0.8f));

            //rotateX = true;
        }
    }

    public void SwipedRight()
    {
        if (rotateX)
        {
            Debug.Log("Is still rotating");
        }
        else
        {
            Debug.Log("Swiped Right");

            rotX = transform.rotation.eulerAngles.x;
            rotY = transform.rotation.eulerAngles.y + 90;

            //StartCoroutine(Rotate(rotX, rotY, 0.8f));

            rotateX = true;
        }
    }

    public void SwipedUp()
    {
        if (rotateY)
        {
            Debug.Log("Is still rotating");
        }
        else
        {
            Debug.Log("Swiped Up");

            rotX = transform.rotation.eulerAngles.x + 90;
            rotY = transform.rotation.eulerAngles.y;

            //StartCoroutine(Rotate(rotX, rotY, 0.8f));

            //float b = transform.rotation.eulerAngles.x + 90;
            targetRotation = transform.rotation;

            targetRotation *= Quaternion.AngleAxis(90, Vector3.right);
            StartCoroutine(RotateA(targetRotation, 0.8f));

            //rotateY = true;
        }
    }

    public void SwipedDown()
    {
        if (rotateY)
        {
            Debug.Log("Is still rotating");
        }
        else
        {
            Debug.Log("Swiped Down");

            rotX = transform.rotation.eulerAngles.x - 90;
            rotY = transform.rotation.eulerAngles.y;

            //StartCoroutine(Rotate(rotX, rotY, 0.8f));

            rotateY = true;
        }
    }

    /*void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
        transform.Rotate(transform.rotation.eulerAngles.x, rotX, transform.rotation.eulerAngles.z, Space.Self);
    }*/

    IEnumerator Rotate(float rotX, float rotY, float inTime)
    {
        timer = 0;
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(rotX, rotY, transform.rotation.eulerAngles.z);

        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);

            yield return null;
        }
        transform.rotation = toAngle;
    }

    IEnumerator RotateA(Quaternion rotation, float inTime)
    {
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, t);

            yield return null;
        }
        transform.rotation = rotation;

    }
}
