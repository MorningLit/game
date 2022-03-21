using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    List<PowerUp> powerUps;

    public Inventory() {
        powerUps = new List<PowerUp>();
        addPowerUp(new PowerUp{powerUpType = PowerUp.PowerUpType.Dash, amount = 1});
        addPowerUp(new PowerUp{powerUpType = PowerUp.PowerUpType.Jump, amount = 1});
        addPowerUp(new PowerUp{powerUpType = PowerUp.PowerUpType.Attack, amount = 1});
        addPowerUp(new PowerUp{powerUpType = PowerUp.PowerUpType.Regen, amount = 1});
        addPowerUp(new PowerUp{powerUpType = PowerUp.PowerUpType.Time, amount = 1});
    }
    public void addPowerUp(PowerUp powerUp) {
        powerUps.Add(powerUp);
    }

    public List<PowerUp> GetPowerUps() {
        return powerUps;
    }    
}
