using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCulo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement_RB>()) // comporbamos que el objeto que esta colisionando con el culo tiene es el jugador
        {
            Debug.Log("Recuperaste tu culo");
            Destroy(gameObject); // destruimos el objeto del culo por si acaso
            GameManager.instance.LoadScene("Victory"); // cargamos la escena de victoria
        }
    }
}
