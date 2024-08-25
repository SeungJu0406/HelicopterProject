using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightArm : MonoBehaviour
{
    enum Direction { Up, Down }

    [SerializeField] float speed;
    [SerializeField] Transform target;

    private Direction nowDir;
    private void Update()
    {
        //Check();
        Rotate();
        Debug.Log($"{nowDir}");
        Debug.Log($"{transform.rotation.z}");
    }
    void Rotate()
    {
        transform.Rotate(Vector3.forward,speed*Time.deltaTime);
    }

    void Check()
    {

    }
}
