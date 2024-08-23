using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed;

    [SerializeField] RotateWings RotateWings;
    private void Start()
    {
        RotateWings.OnRotateMax += Fly;
    }
    void Fly()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }
}
