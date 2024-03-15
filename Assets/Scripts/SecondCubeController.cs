using UnityEngine;

public class SecondCubeController : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _sizeChangeSpeed;

    private void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
        transform.RotateAround(transform.position, Vector3.up, _rotationSpeed);
        transform.localScale += _sizeChangeSpeed;
    }
}
