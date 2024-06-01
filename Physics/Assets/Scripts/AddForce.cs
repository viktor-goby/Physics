using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           /* _rigidbody.AddForce(0f, 300f, 0f);
            _rigidbody.AddForce(Vector3.up * 300f);*/
            _rigidbody.AddForce(Vector3.up * 300f, ForceMode.Impulse);
            
        }
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-5, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(5, 0f, 0f);
        }
    }
}
