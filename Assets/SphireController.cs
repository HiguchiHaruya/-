using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphireController : MonoBehaviour
{
    Rigidbody _rb;
    bool isStop = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (!isStop) _rb.velocity = new Vector3(0, 0, 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal")) isStop = true;
    }
}
