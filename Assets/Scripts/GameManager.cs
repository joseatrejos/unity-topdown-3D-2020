using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    Player player;

    public Player Player { get => player; }

    bool isInCombat = false;
    public bool IsInCombat { get => isInCombat; set => isInCombat = value; }

    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void StartCombat()
    {
        isInCombat = true;
        player.Animator.SetLayerWeight(1, 1);
        player.WeaponVisibility(true);
    }

    public void EscapeCombat()
    {
        isInCombat = false;
        player.Animator.SetLayerWeight(player.Animator.GetLayerIndex("Base Layer"), 1);
        player.Animator.SetLayerWeight(player.Animator.GetLayerIndex("Combat"), 0);
        player.WeaponVisibility(false);

        /*
        Debug.Log("Base Layer Index: " + player.Animator.GetLayerIndex("Base Layer"));
        Debug.Log("Base Layer Weight: " + player.Animator.GetLayerWeight(player.Animator.GetLayerIndex("Base Layer")));
        Debug.Log("Combat Layer Index: " + player.Animator.GetLayerIndex("Combat"));
        Debug.Log("Combat Layer Weight: " + player.Animator.GetLayerWeight(player.Animator.GetLayerIndex("Combat")));
        */
    }
}
