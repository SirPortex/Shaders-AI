using IdyllicFantasyNature;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemey : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement_RB>())
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth)
            {
                playerHealth.LoseLifes();
            }
        }
    }
}
