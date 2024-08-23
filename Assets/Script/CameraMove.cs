using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float mainX;
    [SerializeField] float mainY;
    [SerializeField] float mainZ;

    [SerializeField] Transform player; 
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        
    }
}
