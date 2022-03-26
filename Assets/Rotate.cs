using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    SpriteRenderer _sprite; 
    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _sprite.transform.RotateAround(transform.position, new Vector3(0, 1, 0), Time.deltaTime * 100.0f);
    }
}
