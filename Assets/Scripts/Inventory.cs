using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    List<PowerUp> powerUps;

    public Inventory() {
        powerUps = new List<PowerUp>();
    }
    public void addPowerUp(PowerUp powerUp) {
        powerUps.Add(powerUp);
    }
}
