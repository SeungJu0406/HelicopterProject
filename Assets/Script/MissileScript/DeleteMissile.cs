using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMissile : MonoBehaviour
{
    [SerializeField] float time;
    [HideInInspector] float curTime;

    private void Awake()
    {
        Init();
    }
    void Update()
    {
        CheckTime();
    }

    private void OnDestroy()
    {
    }

    void Init()
    {

    }
    void CheckTime()
    {
        curTime += 1 * Time.deltaTime;
        if (curTime >= time) 
        {
            Delete();
        }
    }
    public void Delete()
    {
        Destroy(gameObject);
    }
}
