using UnityEngine;

public class RotateWings : MonoBehaviour
{
    [HideInInspector] public float curRotateSpeed;
    [SerializeField] public float maxRotateSpeed;
    [SerializeField] float timeToMax;
    [SerializeField] public float fuel;

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
                curRotateSpeed -= maxRotateSpeed / timeToMax * Time.deltaTime;
                fuel += 10 * Time.deltaTime;
                if (curRotateSpeed < 0)
                    curRotateSpeed = 0;
            }          
            if(fuel <= 0)
                canFlying = false;
        }
        else
        {
            curRotateSpeed -= maxRotateSpeed / timeToMax * Time.deltaTime;
            fuel += 10 * Time.deltaTime;
            if (curRotateSpeed < 0)
                curRotateSpeed = 0;
            if (fuel > 50)
                canFlying = true;
        }
        transform.Rotate(Vector3.up * curRotateSpeed * Time.deltaTime);
    }
}
