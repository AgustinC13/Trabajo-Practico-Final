using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_de_Escena : MonoBehaviour
{

    public Hud hud;
    

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && hud.Key == true)
        {
            SceneManager.LoadScene("Nivel 1 - 2");
          
        }
    }
}
