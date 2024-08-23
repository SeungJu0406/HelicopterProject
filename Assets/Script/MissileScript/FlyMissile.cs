using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMissile : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        Fly();
    }
    void Fly()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }

    
}
