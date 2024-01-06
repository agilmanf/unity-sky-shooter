using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7f;

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }
}
