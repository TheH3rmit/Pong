using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody2D;
    [SerializeField] float moveSpeed = 10f;
    public float moveSpeedPublic
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void ReestPaddle(Vector3 velocity, Vector3 position)
    {
        _rigidbody2D.velocity = velocity;
        _rigidbody2D.position= position;
    }

}
