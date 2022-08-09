using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarAzul : MonoBehaviour
{

    public GameObject Player1;
    public GameObject Player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
            Destroy(gameObject);
        }
    }

}
