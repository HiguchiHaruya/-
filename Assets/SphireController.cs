using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphireController : MonoBehaviour
{
    Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        _rb.velocity = new Vector3(0, 0, -3f);
    }
}
