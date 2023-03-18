using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : Paddle
{
    public Rigidbody2D ball;


    private void FixedUpdate()
    {
        //needs revisit as it is not working as intended
        if (ball.velocity.x > 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (ball.position.y > _rigidbody2D.position.y)
            {
                _rigidbody2D.AddForce(Vector2.up * moveSpeedPublic);
            }
            else if (ball.position.y < _rigidbody2D.position.y)
            {
                _rigidbody2D.AddForce(Vector2.down * moveSpeedPublic);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (_rigidbody2D.position.y > 0f)
            {
                _rigidbody2D.AddForce(Vector2.down * moveSpeedPublic);
            }
            else if (_rigidbody2D.position.y < 0f)
            {
                _rigidbody2D.AddForce(Vector2.up * moveSpeedPublic);
            }
        }
    }
}
