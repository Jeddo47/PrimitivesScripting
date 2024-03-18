using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
    }
}
