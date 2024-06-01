using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private Collider ColliderA;
    [SerializeField] private Collider ColliderB;

    private void Start()
    {
        Physics.IgnoreCollision(ColliderA, ColliderB);
    }
}
