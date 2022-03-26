using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJoystick : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private Vector3 _direction;

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector3(_joystick.Horizontal, 0.0f, _joystick.Vertical);
        GetComponent<IMoveable>().SetDirection(_direction);
    }
}
