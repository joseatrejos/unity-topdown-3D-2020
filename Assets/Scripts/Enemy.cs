using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)]
    float moveSpeed = 3.5f;

    [SerializeField, Range(0f, 10f)]
    float minDistance = 5f;

    NavMeshAgent navMeshAgent;

    void Update()
    {
        if(AttackRange)
        {
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            navMeshAgent.destination = GameManager.instance.Player.transform.position;
            transform.LookAt(GameManager.instance.Player.transform);
        }
    }

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    bool AttackRange
    {
        get => Vector3.Distance(this.transform.position, GameManager.instance.Player.transform.position) <= minDistance;
    }
}
