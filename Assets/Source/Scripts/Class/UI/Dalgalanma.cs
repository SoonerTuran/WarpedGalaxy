using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalgalanma : MonoBehaviour
{
    public float miktar = 1.0f;
    private float dalgalanma = 0;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        dalgalanma += Time.deltaTime * speed;

        DalgaUret(dalgalanma);
    }

    void DalgaUret(float x)
    {
        transform.position = new Vector3(miktar * Mathf.Sin(x), miktar * Mathf.Cos(x), -miktar/2 * Mathf.Cos(x));
    }
}
