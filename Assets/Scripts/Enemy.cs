using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)]
    float moveSpeed = 3.5f;

    [SerializeField, Range(0f, 10f)]
    float minDistance = 5f;

    void Update()
    {
        if(1 == 1)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.LookAt(GameManager.instance.Player.transform);
        }
    }
    
    bool AttackRange
    {
        get => Vector3.Distance(this.transform.position, GameManager.instance.Player.transform.position) <= minDistance;
    }
}
