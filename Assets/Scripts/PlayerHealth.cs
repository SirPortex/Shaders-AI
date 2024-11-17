using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PlayerHealth : MonoBehaviour
{
    private int lifes = 3;
    LIFE lifeInterface;
    // Start is called before the first frame update
    void Start()
    {
        lifeInterface = FindObjectOfType<LIFE>(); // encontramos el objeto --> canvas
        lifes = lifeInterface.vidas.Length;
    }


    public void ChangeScene()
    {
        GameManager.instance.LoadScene("Defeat"); //Cambiamos de escena a derrota
    }

    public void LoseLifes()
    {
        lifes -= 1; //Quitamos una vida
        if (lifes == 0) //Si tenemos 0 vidas cambia de escena
        {
            ChangeScene();
        }

        lifeInterface.DesactiveLifes(lifes);
    }
    public bool ReturnLifes()
    {
        if (lifes == 3)
        {
            return false;
        }

        lifeInterface.ActiveLifes(lifes);
        lifes += 1;
        return true;
    }
}
