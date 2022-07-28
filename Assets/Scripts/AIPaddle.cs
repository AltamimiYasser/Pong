using UnityEngine;

public class AIPaddle : Paddle
{
    [SerializeField] Rigidbody2D ballRb;
    float ballDirection;

    void FixedUpdate()
    {
        if (ballRb.velocity.x > 0)
        {
            if (ballRb.position.y > transform.position.y) rb.AddForce(Vector2.up * speed);
            if (ballRb.position.y < transform.position.y) rb.AddForce(Vector2.down * speed);
        }
        else
        {
            if (transform.position.y > 0) rb.AddForce(Vector2.down * speed);
            if (transform.position.y < 0) rb.AddForce(Vector2.up * speed);
        }
    }
}
