using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegdollControl : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody[] _allRigidbodys;

    private void Awake()
    {
        for(int i = 0;  i < _allRigidbodys.Length; i++)
        {
            _allRigidbodys[i].isKinematic = true;
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    private void MakePhysical()
    {
        _animator.enabled = false;
        for(int i = 0; i < _allRigidbodys.Length; i++)
        {
            _allRigidbodys[i].isKinematic = false;
        }
    }

}
