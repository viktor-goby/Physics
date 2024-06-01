using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            JointSpring jointSpring = _hingeJoint.spring;
            jointSpring.targetPosition = 90f;
            _hingeJoint.spring = jointSpring;
        } 
        
        
    }
}
