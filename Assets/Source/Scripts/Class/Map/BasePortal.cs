using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasePortal : MonoBehaviour
{
    public int _id;
    public Vector3 _coordinat;
    public BaseMap _goMap;

    private void Start()
    {
        this.gameObject.transform.position = _coordinat;
    }

}
