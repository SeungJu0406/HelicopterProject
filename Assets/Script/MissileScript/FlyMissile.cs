using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMissile : MonoBehaviour
{
    [SerializeField] float speed;

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
        transform.rotation = Quaternion.Euler(
            transform.rotation.eulerAngles.x + 90, 
            transform.rotation.eulerAngles.y, 
            transform.rotation.eulerAngles.z);
        transform.position += transform.up * 1;
        transform.position -= transform.forward * 1;
    }
    
}
