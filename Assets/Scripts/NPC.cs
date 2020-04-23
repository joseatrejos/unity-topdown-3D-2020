using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField]
    GameObject npcTextBox;

    public void StartTalking()
    {
        npcTextBox.SetActive(true);
    }

    public void StopTalking()
    {
        npcTextBox.SetActive(false);
    }
    
    void OnTriggerEnter(Collider col)
    {
        if( col.CompareTag("Player") )
        {
            StartTalking();
        }
    }

     void OnTriggerExit(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            StopTalking();
        }
    }
}
