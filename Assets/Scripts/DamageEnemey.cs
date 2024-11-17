using IdyllicFantasyNature;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemey : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement_RB>()) // Si colisionamos con un objeto que tiene el componente del jugador
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>(); 
            if (playerHealth)
            {
                playerHealth.LoseLifes(); //Llamamos al metodo que nos quita una vida
            }
        }
    }
}
