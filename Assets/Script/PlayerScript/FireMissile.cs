using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    [SerializeField] GameObject missile;
    [SerializeField] Queue<GameObject> missiles = new Queue<GameObject>();
    [SerializeField] float firePerSecond;
    [SerializeField] int maxMissile;
    float curTime;
    float fireTime;

    private void Awake()
    {
        Init();
    }
    void Update()
    {
       
        CheckTime();
        InputKey();
    }

    void Init()
    {
        fireTime = 1.0f / firePerSecond;
        curTime = fireTime;
    }

    void InputKey()
    {
        if (Input.GetButton("Fire"))
        {
            Fire();
        }
    }
    void Fire()
    {
        if (missiles.Count > 0)
        {
            GameObject m = missiles.Dequeue();
            Instantiate(m,transform.position,transform.rotation);           
        }
    }
    void CheckTime()
    {
        if (missiles.Count == 1)
            return;
        curTime += 1 * Time.deltaTime;        
        if(curTime>= fireTime)
        {
            missiles.Enqueue(missile);
            curTime = 0;           
        }
    }

}
