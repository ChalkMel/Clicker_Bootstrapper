using System;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    [SerializeField] private float range;
    private Rigidbody _rigidbody;
    private ConfigurableJoint _joint;
    private const int base_force = 1000;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _joint = GetComponent<ConfigurableJoint>();
        _rigidbody.AddForce(transform.right * base_force);
    }

    private void Update()
    {
        if (_rigidbody.linearVelocity.magnitude <= range)
        {
            _rigidbody.AddForce(transform.right * (range * base_force));
        }
    }
}
