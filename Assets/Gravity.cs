using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0.1f, 0.1f, 0) * rb.mass);
    }
}
