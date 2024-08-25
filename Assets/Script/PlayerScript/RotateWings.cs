using UnityEngine;

public class RotateWings : MonoBehaviour
{
    [HideInInspector] public float curRotateSpeed;
    [SerializeField] public float maxRotateSpeed;
    [SerializeField] public float timeToMax;
    [SerializeField] float maxFuel;
    [HideInInspector]public float fuel;
    bool canFlying;

    private void Awake()
    {   
        curRotateSpeed = 0;
        canFlying = true;
    }
    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        if (canFlying)
        {
            if (Input.GetButton("StartEngine"))
            {
                curRotateSpeed += maxRotateSpeed / timeToMax * Time.deltaTime;
                fuel -= 10 * Time.deltaTime;
                if (curRotateSpeed > maxRotateSpeed)
                {
                    curRotateSpeed = maxRotateSpeed;
                }
            }
            else
            {
                IsStopRotate();
            }          
            if(fuel <= 0)
                canFlying = false;
        }
        else
        {
            IsStopRotate();
            if (fuel > 50)
                canFlying = true;
        }
        transform.Rotate(Vector3.up * curRotateSpeed * Time.deltaTime);
    }

    void IsStopRotate()
    {
        curRotateSpeed -= maxRotateSpeed / timeToMax * Time.deltaTime;
        fuel += 10 * Time.deltaTime;
        if(fuel >= maxFuel)
            fuel = maxFuel;
        if (curRotateSpeed < 0)
            curRotateSpeed = 0;
    }
}
