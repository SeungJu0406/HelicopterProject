using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMissile : MonoBehaviour
{
    [SerializeField] float time;
    [HideInInspector] float curTime;
    void Update()
    {
        CheckTime();
    }
    void CheckTime()
    {
        curTime += 1 * Time.deltaTime;
        if (curTime >= time) 
        {
            Delete();
        }
    }
    void Delete()
    {
        Destroy(gameObject);
    }
}
