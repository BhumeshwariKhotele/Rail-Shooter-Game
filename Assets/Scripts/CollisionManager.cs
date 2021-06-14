using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] GameObject deathEffect;
    private void OnTriggerEnter(Collider other)
    {
        PlayerDeath(); 
    }

    private void PlayerDeath()
    {
        Debug.Log("Player Dead");
      //  SendMessage("OnPlayerDeath");
        //deathEffect.SetActive(true);
    }
}
