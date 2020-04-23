using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Items/Potion", order = 1)]

public class Potion : Consumable
{
    [SerializeField]
    int healthPoints;
    
    [SerializeField]
    int manaPoints;

    public int RestoreHealth { get => healthPoints; }
    public int RestoreMana { get => manaPoints; }

    public override void Drink()
    {
        base.Drink();
        Debug.Log("Potion Consumed");
    }
}
