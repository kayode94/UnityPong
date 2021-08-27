using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // speed utilized by player paddle and computer paddle
    public float speed = 10.0f;

    // We need to establish a reference to the rigid body
    // that exists on the same game object as the paddle.
    protected Rigidbody2D _rigidbody;
    
    // used for initialization type functions
    private void Awake() 
    {   // establishing the rigidbody reference
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
