using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeCollider : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>(); //Creamos una lista de objetos que seran los que entren en contacto con el cono

    private void OnTriggerEnter(Collider other)
    {
        list.Add(other.gameObject); // Si se detecta una colision con el cono se añade un elemento a la lista
    }

    private void OnTriggerExit(Collider other)
    {
        list.Remove(other.gameObject); // Si el objecto que se detecta sale del cono se elimina un elemento de la lista
    }
    
    public List<GameObject> GetVisionList()
    {
        return list;
    }
}
