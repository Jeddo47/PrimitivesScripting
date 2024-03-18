using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotationSpeed);        
    }
}
