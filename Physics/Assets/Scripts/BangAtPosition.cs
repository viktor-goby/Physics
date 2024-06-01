using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    [SerializeField] private Rigidbody _targetRigidbody;
    [SerializeField] private float _forceValue;


    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            _targetRigidbody.AddForceAtPosition(transform.up * _forceValue, transform.position);
            
        }
    }

}
