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
        Check();
        Rotate();
        Debug.Log($"{nowDir}");
        Debug.Log($"{transform.rotation.z}");
    }
    void Rotate()
    {
        if (nowDir == Direction.Up)
        {
            transform.RotateAround(target.position, Vector3.forward, -1* speed * Time.deltaTime);
        }
        else if (nowDir == Direction.Down)
        {
            transform.RotateAround(target.position, Vector3.forward, speed * Time.deltaTime);
        }
    }

    void Check()
    {
        if(transform.rotation.z <= -185)
        {
            nowDir = Direction.Up;
        }
        else if (transform.rotation.z >= 100)
        {
            nowDir = Direction.Down;
        }
    }
}
