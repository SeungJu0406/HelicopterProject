using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rate;

    [SerializeField] float rotateSpeed;
    private Vector3 angle = new Vector3();

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //이동
        Vector3 moveDir = new Vector3 (0, 0, z);
        moveDir.Normalize();
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);

        //회전
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime);
    }
}
