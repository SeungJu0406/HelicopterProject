using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMissile : MonoBehaviour
{
    [SerializeField] float time;
    [HideInInspector] float curTime;
    GameObject player;
    FireMissile fireMissile;

    private void Start()
    {
        this.player = GameObject.Find("Doraemong");
        fireMissile = player.GetComponent<FireMissile>();
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
            fireMissile.DeleteMissile(gameObject);
        }
    }
    public void Delete()
    {
        Destroy(gameObject);
    }
}
