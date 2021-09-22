using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 100f;

    private Rigidbody2D RB2D;

    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();

        RB2D.velocity = Vector2.up * speed;
        
    }

    float hitFactor(Vector2 BallPos , Vector2 RacketPos , float RacketWidth)
    {
        return (BallPos.x - RacketPos.x) / RacketWidth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name == "Vaus")
        {

            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;

            RB2D.velocity = dir * speed;

        }
    }
}
