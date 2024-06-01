using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftControl : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * _rotationSpeed;
        float vertical = Input.GetAxis("Vertical") * _speed;

        _rigidbody.AddRelativeForce(0, 0f, vertical);
        _rigidbody.AddRelativeTorque(0f, horizontal, 0f);
    }

}
