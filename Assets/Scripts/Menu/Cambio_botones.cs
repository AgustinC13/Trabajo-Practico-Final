using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cambio_botones : MonoBehaviour
{

    public void Siguiente()
    {
        SceneManager.LoadScene("Nivel 2");
    }


}
