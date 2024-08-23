using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWings : MonoBehaviour
{
    float curRotateSpeed;
    [SerializeField] float maxRotateSpeed;
    [SerializeField] float timeToMax;

    private void Awake()
    {
        curRotateSpeed = 0;
    }
    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        if (Input.GetButton("StartEngine"))
        {
            curRotateSpeed += maxRotateSpeed / timeToMax * Time.deltaTime;
            if (curRotateSpeed > maxRotateSpeed)
                curRotateSpeed = maxRotateSpeed;
        }
        else
        {
            curRotateSpeed -= maxRotateSpeed / timeToMax * Time.deltaTime;
            if (curRotateSpeed < 0)
                curRotateSpeed = 0;
        }
        transform.Rotate(Vector3.up * curRotateSpeed * Time.deltaTime);
    }
}
