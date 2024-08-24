using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    private void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}
