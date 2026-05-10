using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private InputAction moveAction;
    private Rigidbody2D _rb;
    [SerializeField] private float moveSpeed;
    private float baseMoveSpeed;
    [SerializeField] private float torqueStr=1f;
    

    private void Start()
    {
        baseMoveSpeed = moveSpeed;
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

    public void setMoveSpeed(float moveSpeed)
    {
        this.moveSpeed=moveSpeed;
    }

    public void resetMoveSpeed()
    {
        moveSpeed=baseMoveSpeed;
    }
}
