using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnJoystick : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private Vector3 _direction;

    // Update is called once per frame
    void Update()
    {   
        _direction = new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical);
        if (_direction.normalized.magnitude > 0)
        {
            GetComponent<ITurnable>().SetDirection(_direction.normalized);
        }
        
    }
}
