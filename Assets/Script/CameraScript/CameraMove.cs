using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float mainX;
    [SerializeField] float mainY;
    [SerializeField] float mainZ;
    [SerializeField] float cameraSpeed;

    [SerializeField] GameObject target;
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        Vector3 targetPos = new Vector3(
            mainX + target.transform.position.x,
            mainY + target.transform.position.y,
            mainZ + target.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, cameraSpeed);
    }
}
