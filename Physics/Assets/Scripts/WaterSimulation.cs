using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSimulation : MonoBehaviour
{
    [SerializeField] private float _waterDensity;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float divePercent = -transform.position.y + transform.localScale.x * 0.5f;
        divePercent = Mathf.Clamp(divePercent, 0f, 1f);

        _rigidbody.AddForce(Vector3.up * divePercent * _waterDensity);
        _rigidbody.drag = divePercent * 2f;
        _rigidbody.angularDrag = divePercent * 2f;
    }
}
