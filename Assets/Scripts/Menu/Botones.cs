using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
  //  public Button Jugar;
  //  public Button Historia;
  // public Button Volver;
  // public Button Controles;
  //  public Button Salir;

    public void jugar ()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void historia ()
    {
        SceneManager.LoadScene("Historia");
    }

    public void volver()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
    
    public void salir()
    {
        Application.Quit();
    }

}
