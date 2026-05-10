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
        if (item != null)
        {
            StartCoroutine(PowerUpTimer(item._powerUp.powerBoost,item._powerUp.powerTime));
        }
    }

    IEnumerator PowerUpTimer(float moveSpeed, float time)
    {
        SetMoveSpeed(moveSpeed);
        yield return new WaitForSeconds(time);
        ResetMoveSpeed();
    }

    private void SetMoveSpeed(float moveSpeed)
    {
        surfaceEffector.speed = moveSpeed;
    }

    private void ResetMoveSpeed()
    {
        surfaceEffector.speed = currentMoveSpeed;
    }
    
}
