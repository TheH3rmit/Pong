using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : Paddle
{
    public Rigidbody2D ball;


    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if(ball.position.y> this.transform.position.y)
            {
                _rigidbody2D.AddForce(Vector2.up * moveSpeedPublic,ForceMode2D.Impulse);
            }
            else if (ball.position.y < this.transform.position.y)
            {
                _rigidbody2D.AddForce(Vector2.down * moveSpeedPublic, ForceMode2D.Impulse);
            }
            else if (ball.position.y == this.transform.position.y)
            {
                _rigidbody2D.AddForce(-_rigidbody2D.velocity.normalized * moveSpeedPublic, ForceMode2D.Impulse);
            }
        }
        else
        {
            if (_rigidbody2D.position.y > 0.0f)
            {
                _rigidbody2D.AddForce(Vector2.down * moveSpeedPublic, ForceMode2D.Impulse);
            }
            else if (_rigidbody2D.position.y < 0.0f)
            {
                _rigidbody2D.AddForce(Vector2.up * moveSpeedPublic, ForceMode2D.Impulse);
            }
            _rigidbody2D.AddForce(-_rigidbody2D.velocity.normalized * moveSpeedPublic, ForceMode2D.Impulse);
        }
    }
}
