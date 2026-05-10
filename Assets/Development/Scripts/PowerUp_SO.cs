using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp_SO", menuName = "Scriptable Objects/PowerUp_SO")]
public class PowerUp_SO : ScriptableObject
{
    public Color powerUpColor;
    public string powerName;
    public float powerBoost;
    public float powerTime;
}
