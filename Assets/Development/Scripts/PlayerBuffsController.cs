using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuffsController : MonoBehaviour
{
    
    [SerializeField] private GameObject ground;
    [SerializeField] private PlayerControl playercont;
    private void Start()
    {
        
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
        playercont.setMoveSpeed(moveSpeed);
        yield return new WaitForSeconds(time);
        playercont.resetMoveSpeed();
    }
    
}
