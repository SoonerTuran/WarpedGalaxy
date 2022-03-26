using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseMap : MonoBehaviour
{
    public string _name;
    public int _id;
    public BasePortal[] _portals;
    public BaseSafeArea _safeArea;
    public BaseCharacter[] _chararecters;

    public Canvas _canvas;
    [HideInInspector] public Vector2 _boundary;

    private void Start()
    {
        RectTransform _recttransform = _canvas.GetComponent< RectTransform>();
        _boundary = _recttransform.sizeDelta;
    }
}
