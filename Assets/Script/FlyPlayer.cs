using UnityEngine;

public class FlyPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed;
    [SerializeField] RotateWings rotateWings;
    [SerializeField][Range(0, 50)] float maxY;

    [SerializeField] Rigidbody rigidbody;
    [SerializeField][Range(0,5)] float landingSpeed;

    private void Update()
    {
        Fly(rotateWings);
    }
    void Fly(RotateWings rotateWings)
    {
        if (rotateWings.curRotateSpeed == rotateWings.maxRotateSpeed &&
            transform.position.y <= maxY)
        {
            transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
            rigidbody.drag = 100;
        }
        else
        {
            rigidbody.drag = 5 - landingSpeed;
        }
    }
}
