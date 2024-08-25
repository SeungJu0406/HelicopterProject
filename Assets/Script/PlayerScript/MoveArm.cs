using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    enum MoveDir { Up, Down }
    [SerializeField] float speed;
    [SerializeField][Range(0,50)] float rotateRange;

    [HideInInspector] MoveDir nowDir;
    void Update()
    {
        Check();
        Move();
    }

    void Move()
    {
        if (nowDir == MoveDir.Up)
        {
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
        else if (nowDir == MoveDir.Down)
        {
            transform.Rotate(Vector3.forward, -1 * speed * Time.deltaTime);
        }
    }
    void Check()
    {
        if( rotateRange < transform.eulerAngles.z && transform.eulerAngles.z < 100)
        {
            nowDir = MoveDir.Down;
        }
        else if (200 < transform.eulerAngles.z && transform.eulerAngles.z < 360 - rotateRange)
        {
            nowDir = MoveDir.Up;
        }
    }
}
