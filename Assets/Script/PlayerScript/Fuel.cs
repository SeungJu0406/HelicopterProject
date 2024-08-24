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
        rotateWings = wing.GetComponent<RotateWings>();
    }
    void PrintFuel()
    {
        if (rotateWings.fuel > 0)
        {
            transform.localScale = new Vector3(
                1 - (1.0f - rotateWings.fuel / 100.0f),
                transform.localScale.y,
                transform.localScale.z);
        }
    }
}
