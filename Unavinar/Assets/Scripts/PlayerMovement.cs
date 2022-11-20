using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start() => _rb.velocity = Vector3.right * _speed;
    
    private void Update()
    {
        if (Input.GetMouseButton(0))
            _rb.velocity += Vector3.right;
        else
            _rb.velocity = Vector3.right * _speed;
    }
}
