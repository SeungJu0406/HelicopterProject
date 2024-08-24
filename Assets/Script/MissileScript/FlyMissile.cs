using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMissile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform playerPos;

    private void Start()
    {
        Rotate();
    }
    private void Update()
    {
        Fly();
    }
    void Fly()
    {
        
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
    void Rotate()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x + 90, transform.rotation.y, transform.rotation.z);
    }
    
}
