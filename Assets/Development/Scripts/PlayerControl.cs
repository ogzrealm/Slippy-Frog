using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private InputAction moveAction;
    private Rigidbody2D _rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float torqueStr=1f;
    

    private void Start()
    {
        moveAction=InputSystem.actions.FindAction("Move");
        _rb=GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 moveVector=moveAction.ReadValue<Vector2>();

        if (moveVector.x < 0)
        {
            _rb.AddTorque(torqueStr);
        }
        else if (moveVector.x > 0)
        {
            _rb.AddTorque(-torqueStr);
        }
    }
    
}
