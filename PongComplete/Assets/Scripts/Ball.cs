using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 200.0f;

    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // give the ball a starting force
    private void Start() 
    {
       ResetPosition();
       AddStartingForce();
    }

    public void AddStartingForce()
    {
        // pick a random direction left or right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        // the y will dictate the angle of the ball 
        // Random.Range(min, max)
        float y = Random.value > 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

}
