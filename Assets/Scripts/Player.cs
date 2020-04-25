using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    float moveSpeed = 0;

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Axis.normalized.magnitude * Vector3.forward * moveSpeed * Time.deltaTime);
 
        if(Axis != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Axis.normalized);
        }

        animator.SetFloat("move", Mathf.Abs(Axis.normalized.magnitude));
    }

    Vector3 Axis
    {
        get => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}
