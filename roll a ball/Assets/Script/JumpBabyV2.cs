using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBabyV2 : MonoBehaviour
{
    public bool isFalling;
    private Rigidbody rb;

    private void Start()
    {
        isFalling = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isFalling == false)
        {
            if (Input.GetButtonDown("Jump") && isFalling == false)
            {
                isFalling = true;
                rb.velocity = new Vector3(0, 8, 0);
              
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }
}
