using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{

    public float speed = 150f;

    private Rigidbody2D RB2D;

    private void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");

        RB2D.velocity = Vector2.right * h * speed;
      
    }

}
