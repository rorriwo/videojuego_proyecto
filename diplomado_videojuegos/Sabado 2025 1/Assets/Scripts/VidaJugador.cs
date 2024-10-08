using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VidaJugador : MonoBehaviour
{
    public static int vida = 100;
    private TextMeshProUGUI mostradorVida;

    private int vidaAnterior;

    public Animator anim;

    private GameObject panelPerdiste;


    // Start is called before the first frame update
    void Start()
    {
        mostradorVida = GameObject.FindGameObjectWithTag("VidaJugador").GetComponent<TextMeshProUGUI>();
        mostradorVida.text = "vida: " + vida;
        vidaAnterior = vida;

        panelPerdiste = GameObject.FindGameObjectWithTag("PanelPerdiste");
        panelPerdiste.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Vida: " + vida);

        if (vida <= 0)
        {
            panelPerdiste.SetActive(true);
            vida = 0;
            MovePlayer1.jugadorVivo = false;
            Time.timeScale = 0;
        }

        if(vida != vidaAnterior)
        {
            mostradorVida.text = "Vida: " + vida;
            anim.SetTrigger("recibirDanio");
        }

        if (vida <= 0)
        {
            Debug.Log("Se murio el jugador");
        }
        vidaAnterior = vida;
    }
}
