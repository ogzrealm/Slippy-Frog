using System;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private PlayerControl _player;

    private void Start()
    {
        _player = GameObject.FindAnyObjectByType<PlayerControl>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.FinishLevel();
            _player.isPlayerCanRotate = false;
        }
    }
}
