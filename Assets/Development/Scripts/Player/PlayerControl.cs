using System;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private InputAction moveAction;
    private Rigidbody2D _rb;
    [SerializeField] private float torqueStr=1f;
    private float baseTorque;
    private float currentRotation;
    private float previousRotation;
    private float totalRotation;
    private int flips;
    [HideInInspector] public bool isPlayerCanRotate = true;
    

    private void Start()
    {
        moveAction=InputSystem.actions.FindAction("Move");
        _rb=GetComponent<Rigidbody2D>();
        baseTorque = torqueStr;
    }

    private void Update()
    {
        Movement();
        FlipTracker();
    }

    private void Movement()
    {
        if (isPlayerCanRotate)
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

    public void SetNewTorque(float torque)
    {
        torqueStr = torque;
    }

    public void ResetTorque()
    {
        torqueStr = baseTorque;
    }
    
    private void FlipTracker()
    {
        currentRotation = transform.rotation.eulerAngles.z;
        totalRotation += Mathf.DeltaAngle(previousRotation, currentRotation);
        if (totalRotation > 360 || totalRotation < -360)
        {
            flips++;
            AudioController.instance.PlayFlipEffect();
            UIManager.instance.addScore(flips*1000);
            totalRotation = 0;
        }
        
        previousRotation = currentRotation;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            isPlayerCanRotate = false;
            GameManager.instance.GameOver();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) //Debugging for flip bug
    {
        if (other.gameObject.tag == "Ground")
        {
            totalRotation = 0;
        }
    }
}
