using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RenderJugador : MonoBehaviour
{
    private MovePlayer1 mp;
    // Start is called before the first frame update
    void Start()
    {
        mp= GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void aplicarSalto()
    {
        mp.aplicarSalto();
    }*/
}
