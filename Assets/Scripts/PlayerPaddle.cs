using UnityEngine;

public class PlayerPaddle : Paddle
{
    Vector2 direction;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(direction * speed);
    }
}
