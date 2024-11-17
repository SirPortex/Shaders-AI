using IdyllicFantasyNature;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takelifes : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement_RB>().animator.GetBool("IsEmoting") == true) //Comprobamos si el objeto que se ha chocado con nosotros esta realizando el emote
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth)
            {

                Debug.Log("Te curo");
                playerHealth.ReturnLifes(); //Llamamos al metodo que suma una vida
                
            }
        }
    }
}
