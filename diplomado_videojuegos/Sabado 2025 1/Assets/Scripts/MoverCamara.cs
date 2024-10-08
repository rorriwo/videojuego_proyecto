using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public GameObject Jugador;
    public float minX, MaxX;
    // Start is called before the first frame update
    void Start()
    {
        Jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Mathf.Clamp(Jugador.transform.position.x, minX, MaxX), Jugador.transform.position.y + 2, -10);
    }
}
