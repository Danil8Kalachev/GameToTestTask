using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Move();
        Rotation();
    }

    private void Move()
    {
        float vertical = Input.GetAxis(Constants.VERTICAL);
        float direction = vertical * _moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * direction);
    }

    private void Rotation()
    {
        float horizontal = Input.GetAxis(Constants.HORIZONTAL);
        float rotation = horizontal * _rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotation);
    }
}
