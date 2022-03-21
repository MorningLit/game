using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAssets : MonoBehaviour
{
    public static PowerUpAssets Instance {get; private set;}
    private void Awake() {
        Instance = this;
    }
    public Sprite dashSprite;
    public Sprite jumpSprite;
    public Sprite attackSprite;
    public Sprite regenSprite;
    public Sprite timeSprite;
}
