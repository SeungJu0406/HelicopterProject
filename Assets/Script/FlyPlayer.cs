using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed;
    [SerializeField] RotateWings rotateWings;
    [SerializeField] Rigidbody rigidbody;
    private void Update()
    {
        Fly(rotateWings);
    }
    void Fly(RotateWings rotateWings)
    {
        if (rotateWings.curRotateSpeed == rotateWings.maxRotateSpeed) 
        {
            transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
            rigidbody.drag = 100;
        }
        else
        {
            rigidbody.drag = 0;
        }
    }
}
