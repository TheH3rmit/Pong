using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] int moveSpeed = 20;
    private Rigidbody2D _rigidbody2D;
    private void Awake()
    {
        _rigidbody2D= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetBall();
        AddForceOnStart();
    }
    public void AddForceOnStart()
    {
        float x = Random.value < 0.5f ? Random.Range(-1.0f, -0.3f) : Random.Range(0.3f, 1.0f); //if lower than 0.5f then -1.0f if greater then 1.0f
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.3f) : Random.Range(0.3f, 1.0f);

        Vector2 direction = new Vector2(x,y);
        _rigidbody2D.AddForce(direction*moveSpeed);
    }
    public void AddForce(Vector2 force)
    {
        _rigidbody2D.AddForce(force);
    }
    public void ResetBall()
    {
        _rigidbody2D.position= Vector2.zero;
        _rigidbody2D.velocity= Vector2.zero;
    }
}
