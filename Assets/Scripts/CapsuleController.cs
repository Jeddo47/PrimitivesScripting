using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    [SerializeField] private Vector3 _sizeChangeSpeed;

    private void Update()
    {
        transform.localScale += _sizeChangeSpeed;        
    }
}
