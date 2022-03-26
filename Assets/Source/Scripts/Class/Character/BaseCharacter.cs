using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class BaseCharacter : MonoBehaviour, IHealth
{
    public string _name;
    public string _description;
    public string _class;

    public float _health;
    public float _maxhealth;

    public float _attack;
    public float _speed;

    public Joystick _joystick;
    //public Rigidbody _rigidbody;

    public float ModifyHealth(float damage)
    {
        _health -= damage;

        return _health;
    }

    public void Movement(Joystick _joystick)
    {

    }

}
