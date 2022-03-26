using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveCharacter: MonoBehaviour, IMoveable
{
    [SerializeField] private float _speed;

    private Vector3 _direction;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public void SetDirection(Vector3 @direction) 
    {
        _direction = direction;
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _direction * _speed * Time.fixedDeltaTime * 50f;
    }
}
