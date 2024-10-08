using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaSwitch : MonoBehaviour
{
    private GameObject jugador;
    private BoxCollider2D suelo;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        suelo = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //combinar las condiciones de velocidad y altura para mantener tangible la plataforma

        //Debug.Log("velocidad Y del jugador " + jugador.GetComponent<Rigidbody2D>().velocity.y);

        if(jugador.GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            //Debug.Log("La plataforma es solida");
            suelo.enabled = true;
        }
        else
        {
            //Debug.Log("La plataforma es solida");
            suelo.enabled = false;
        }
        /*
        if (jugador.transform.position.y > this.transform.position.y + 1.2f)
        {
            Debug.Log("la plataforma es solida");
            suelo.enabled = true;
        }
        else
        {
            Debug.Log("La plataforma no es solida");
            suelo.enabled = false;
        }*/
    }
}
