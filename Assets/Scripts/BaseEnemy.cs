using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy
{
    public string name;

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Legendary
    }

    public Rarity rarity;

    public float baseHP;
    public float currentHP;

    public float baseATK;
    public float currentATK;
    public float baseDEF;
    public float currentDEF;
}
