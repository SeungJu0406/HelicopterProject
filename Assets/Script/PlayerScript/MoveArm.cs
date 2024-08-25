using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    enum MoveDir { Up, Down }
    [SerializeField] float maxSpeed;
    [SerializeField][Range(0,50)] float rotateRange;

    [SerializeField] GameObject wing;
    RotateWings rotateWings;

    float curSpeed;
    MoveDir nowDir;

    private void Awake()
    {
        curSpeed = 0;
        rotateWings = wing.GetComponent<RotateWings>();
    }
    void Update()
    {
        Check();
        Move();
    }

    public void Accele()
    {
        curSpeed += maxSpeed / rotateWings.timeToMax * Time.deltaTime;
        if (curSpeed > maxSpeed) 
        {
            curSpeed = maxSpeed;
        }
    }
    public void Stop()
    {
        curSpeed -= maxSpeed / rotateWings.timeToMax * Time.deltaTime;
        if (curSpeed < 0)
        {
            curSpeed = 0;
        }
    }
    void Move()
    {
        if (Input.GetButton("StartEngine"))
        {
            Accele();
        }
        else
        {
            Stop();
        }
        if (nowDir == MoveDir.Up)
        {
            transform.Rotate(Vector3.forward, curSpeed * Time.deltaTime);
        }
        else if (nowDir == MoveDir.Down)
        {
            transform.Rotate(Vector3.forward, -1 * curSpeed * Time.deltaTime);
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
