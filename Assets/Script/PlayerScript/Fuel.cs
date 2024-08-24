using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] GameObject wing;

    RotateWings rotateWings;

    private void Start()
    {
        StartInit();
    }
    private void Update()
    {
        PrintFuel();
    }

    void StartInit()
    {
        rotateWings= wing.GetComponent<RotateWings>();
    }
    void PrintFuel()
    {
        if (rotateWings.fuel > 0) 
        {
            transform.localScale = new Vector3(
                transform.localScale.x - ( 100 - rotateWings.fuel) ,
                transform.localScale.y,
                transform.localScale.z);
        }
    }
}
