using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public virtual void Drink()
    {
        // DestroyImmediate(this, true);
        Debug.Log(name + " Consumed");
    }
}
