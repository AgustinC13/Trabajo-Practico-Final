using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pinchos : MonoBehaviour
{

    public int cantidad = 1;

    public Hud hud;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.GetComponent<Dmg_And_Health>().vida > 0)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<Dmg_And_Health>().RestarVida(cantidad);
                hud.vida -= 1;
            }
        }

    }

}
