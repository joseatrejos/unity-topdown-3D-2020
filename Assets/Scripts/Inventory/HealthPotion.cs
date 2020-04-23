using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField]
    Potion potion;

    private void OnTriggerEnter(Collider other)
    {
        potion.Drink();
        Debug.Log("Health Restored");
        Destroy(this.gameObject);
    }
}
