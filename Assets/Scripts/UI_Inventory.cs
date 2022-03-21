using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform powerUpSlot;
    private Transform powerUp;
    private void Awake() {
        powerUpSlot = transform.Find("PowerUpSlot");
        powerUp = powerUpSlot.Find("PowerUp");
    }
    public void SetInventory(Inventory inventory) {
        this.inventory = inventory;
        RefreshPowerUps();
    }
    private void RefreshPowerUps() {
        int x = 0;
        float powerUpSlotCellSize = 75f;
        foreach (PowerUp p in inventory.GetPowerUps()) {
            RectTransform powerUpSlotTransform = Instantiate(powerUp, powerUpSlot).GetComponent<RectTransform>();
            powerUpSlotTransform.gameObject.SetActive(true); 
            powerUpSlotTransform.anchoredPosition = new Vector2(x*powerUpSlotCellSize, 0);
            Image image = powerUpSlotTransform.Find("Image").GetComponent<Image>();
            image.sprite = p.GetSprite();
            ++x;
        }
    }
}
