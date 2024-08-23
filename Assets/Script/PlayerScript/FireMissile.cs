using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Queue<GameObject> missiles;
    [SerializeField] int maxMissile;
    [SerializeField] float firePerSecond;
    float curTime;
    float fireTime;

    private void Awake()
    {
        missiles = new Queue<GameObject>(maxMissile);            
        fireTime = 1.0f / firePerSecond;
        curTime = fireTime;
    }
    void Update()
    {
        InputKey();
    }

    void InputKey()
    {
        if (Input.GetButton("Fire"))
        {
            CheckTime();
        }
    }
    void CheckTime()
    {
        curTime += 1 * Time.deltaTime;        
        if(curTime>= fireTime)
        {
            Fire();
            curTime = 0;
        }
    }
    void Fire()
    {
       missiles.Enqueue(Instantiate(prefab));
    }
}
