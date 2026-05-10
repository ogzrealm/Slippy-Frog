using System;
using UnityEngine;

public class PowerUpItem : MonoBehaviour
{
    public PowerUp_SO _powerUp;


    private void Start()
    {
        GetComponent<SpriteRenderer>().color = _powerUp.powerUpColor;
    }
}
