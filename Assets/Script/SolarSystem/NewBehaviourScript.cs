using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    enum RotateDir { Left, Right }
    [SerializeField] float rotateSpeed;
    [SerializeField] RotateDir rotateDir;
    enum OrbitRotateDir { Left, Right }
    [SerializeField] float orbSpeed;
    [SerializeField] OrbitRotateDir orbDir;
    [SerializeField] Transform target;
    private void Update()
    {
        Rotate();
        OrvitRotate();
    }
    void Rotate()
    {
        if(rotateDir == RotateDir.Right)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        else if(rotateDir == RotateDir.Left)
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
    }
    void OrvitRotate()
    {
        if (orbDir == OrbitRotateDir.Right)
        {
            transform.RotateAround(target.position, Vector3.up, orbSpeed * Time.deltaTime);
        }
        else if (orbDir == OrbitRotateDir.Left)
        {
            transform.RotateAround(target.position, Vector3.down, orbSpeed * Time.deltaTime);
        }
    }
}
