using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public int vida;
    public Image SpriteVida;
    public Sprite MedioCorazon;
    public Sprite CorazonVacio;

    public bool LlaveAgarrada;
    public Image SpriteLlave;
    public Sprite Llave;
    public bool Key;

    public bool GemaAgarrada;
    public Image SpriteGema;
    public Sprite Gema;

    void Start()
    {
        Key = false;
    }


    void Update()
    {
        if (vida == 1)
        {
            SpriteVida.sprite = MedioCorazon;
        }

        if (vida == 0)
        {
            SpriteVida.sprite = CorazonVacio;
        }

        if (LlaveAgarrada == true)
        {
            SpriteLlave.sprite = Llave;
        }

        if (GemaAgarrada == true)
        {
            SpriteGema.sprite = Gema;
        }
    }
}
