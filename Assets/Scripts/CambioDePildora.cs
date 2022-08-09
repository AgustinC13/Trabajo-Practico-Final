using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDePildora : MonoBehaviour
{

    public GameObject OrbeAmarillo;
    public GameObject OrbeAzul;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            Debug.Log("Funciona");
            OrbeAmarillo.SetActive(false);
            OrbeAzul.SetActive(true);
            Destroy(this);
        }
    }

}
