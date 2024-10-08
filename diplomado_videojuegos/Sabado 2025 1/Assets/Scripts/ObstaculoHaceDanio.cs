using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObstaculoHaceDanio : MonoBehaviour
{
    public int danioRealizado = 0;
    private bool tocandoJugador = false;

    public float tiempoEntreDanio = 2;
    private float tiempoTotal = 0;
    //private TextMeshProUGUI vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        //vidaActual = GameObject.FindGameObjectWithTag("VidaJugador").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tocandoJugador)
        {
            tiempoTotal += Time.deltaTime;

            if (tiempoTotal >= tiempoEntreDanio)
            {
                //vidaActual.text = "Vida: " + VidaJugador.vida;
                VidaJugador.vida -=danioRealizado;
                tiempoTotal = 0;
            }
        }
        //Debug.Log("Tiempo acumulado: "+tiempoTotal);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocandoJugador = true;
            VidaJugador.vida -= danioRealizado;
            tiempoTotal = 0;
            Debug.Log("Danio" + this.name);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocandoJugador=false;
        }
    }
}
