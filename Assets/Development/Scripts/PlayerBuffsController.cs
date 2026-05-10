using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuffsController : MonoBehaviour
{
    
    [SerializeField] private GameObject ground;
    [SerializeField] private PlayerControl playercont;
    [SerializeField] private SurfaceEffector2D surfaceEffector;
    private float currentMoveSpeed;
    private void Start()
    {
        currentMoveSpeed = surfaceEffector.speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PowerUpItem item = other.GetComponent<PowerUpItem>();
        if (item != null && item._powerUp.powerName=="Speed")
        {
            StartCoroutine(PowerUpTimer(item._powerUp.powerBoost,item._powerUp.powerTime));
        }
        else if (item != null && item._powerUp.powerName == "Torque")
        {
            StartCoroutine(TorqueTimer(item._powerUp.powerBoost,item._powerUp.powerTime));
        }
    }

    IEnumerator PowerUpTimer(float moveSpeed, float time)
    {
        SetMoveSpeed(moveSpeed);
        yield return new WaitForSeconds(time);
        ResetMoveSpeed();
    }

    IEnumerator TorqueTimer(float torque, float time)
    {
        SetTorqueStr(torque);
        yield return new WaitForSeconds(time);
        ResetTorqueStr();
    }

    private void SetMoveSpeed(float moveSpeed)
    {
        surfaceEffector.speed = moveSpeed;
    }

    private void ResetMoveSpeed()
    {
        surfaceEffector.speed = currentMoveSpeed;
    }

    public void SetTorqueStr(float torque)
    {
        playercont.SetNewTorque(torque);
    }

    public void ResetTorqueStr()
    {
        playercont.ResetTorque();
    }
    
}
