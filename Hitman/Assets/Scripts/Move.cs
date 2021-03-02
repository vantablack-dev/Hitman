using UnityEngine;
using System;

//эта строчка гарантирует что наш скрипт не завалится 
//ести на плеере будет отсутствовать компонент Rigidbody
[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public float Speed = 10f;
    Vector3 moveDirection = Vector3.zero;
    Vector3 movement;
    Vector2 positionChange;

    float lastChangeX = 0;
    float lastChangeY = 0;

    //что бы эта переменная работала добавьте тэг "Ground" на вашу поверхность земли
    private bool _isGrounded;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        MovementLogic();
        transform.Rotate(Vector3.up, Angle360(transform.forward, movement, transform.right));

    }

    float Angle360(Vector3 from, Vector3 to, Vector3 right)
    {
        float angle = Vector3.Angle(from, to);
        return (Vector3.Angle(right, to) > 90f) ? 360f - angle : angle;
    }

    private void MovementLogic()
    {
        if (Input.touchCount > 0)
        {
            Touch mainTouch = Input.GetTouch(0);

            if (mainTouch.phase == TouchPhase.Moved)
            {
                positionChange = mainTouch.deltaPosition;
                if (Math.Abs(positionChange.x - lastChangeX) > 1.5 && Math.Abs(positionChange.y - lastChangeY) > 1.5) 
                {
                    _rb.velocity = Vector3.zero;
                    moveDirection = positionChange.normalized;
                }
            }


            movement = new Vector3(moveDirection.x, 0f, moveDirection.y);
            
            _rb.AddForce(movement * Speed);



            lastChangeX = positionChange.x;
            lastChangeY = positionChange.y;
        }
        if (Input.touchCount == 0) _rb.velocity = Vector3.zero;
    }

  
}