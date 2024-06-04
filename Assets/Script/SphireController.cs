using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphireController : MonoBehaviour
{
    float moveSpeed = 5.0f;
    Rigidbody _rb;
    bool isStop = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (!isStop) _rb.velocity = new Vector3(h * moveSpeed, 0, 7f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal")) isStop = true;
    }
}
