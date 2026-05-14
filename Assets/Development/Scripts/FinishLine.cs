using System;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.FinishLevel();
        }
    }
}
