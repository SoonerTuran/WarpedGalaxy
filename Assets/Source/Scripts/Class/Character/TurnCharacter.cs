using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCharacter : MonoBehaviour, ITurnable
{
    [SerializeField] private float _speed;

    private Vector3 _direction;
    private Quaternion _quaternion;

    public void SetDirection(Vector3 @direction)
    {
        _direction = @direction;
    }

    private void FixedUpdate()
    {
        _quaternion = Quaternion.LookRotation(_direction, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _quaternion, _speed * Time.fixedDeltaTime);
    }
}
