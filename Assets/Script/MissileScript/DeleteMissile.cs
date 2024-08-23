using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMissile : MonoBehaviour
{
    [SerializeField] float time;
    [HideInInspector] float curTime;

    [SerializeField] GameObject player;

    [SerializeField] FireMissile fireMissile;
    private void Awake()
    {
        Init();
    }
    void Update()
    {
        CheckTime();
    }
    
    void Init()
    {
        fireMissile = player.GetComponent<FireMissile>();
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
