using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAim : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private Vector3 _direction;
    SpriteRenderer _aimSprite;

    private void Start()
    {
        _aimSprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical);
        if (_direction.magnitude > 0.5)
        {
             _aimSprite.enabled = true;
            GetComponent<ITurnable>().SetDirection(_direction);
        }
        else
        {
            _aimSprite.enabled = false;
        }

    }
}
