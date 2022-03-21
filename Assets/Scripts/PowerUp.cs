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
    public Sprite GetSprite() {
        switch (powerUpType) {
            default:
            case PowerUpType.Dash: return PowerUpAssets.Instance.dashSprite;
            case PowerUpType.Jump: return PowerUpAssets.Instance.jumpSprite;
            case PowerUpType.Attack: return PowerUpAssets.Instance.attackSprite;
            case PowerUpType.Regen: return PowerUpAssets.Instance.regenSprite;
            case PowerUpType.Time: return PowerUpAssets.Instance.timeSprite;
        }
    }
}
