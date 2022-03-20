using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp 
{
    public enum PowerUpType {
        Dash,
        Jump,
        Attack,
        Regen,
        Time,
    }
    public PowerUpType powerUpType;
    public int amount;
}
