using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dmg_And_Health : MonoBehaviour
{

    public int vida = 2;


    public void RestarVida(int cantidad)
    {

        vida -= cantidad;

        if (vida <= 0)
        {
            SceneManager.LoadScene("Muerte");
        }
    }
}
