using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoMover : MonoBehaviour
{
    public Rigidbody rb = null;

    public float speed = 5;

    public Vector2 move;

    private void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(move.x, 0, move.y) * (speed * Time.deltaTime), ForceMode.Force);
    }
}