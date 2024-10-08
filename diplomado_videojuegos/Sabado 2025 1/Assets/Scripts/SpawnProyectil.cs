using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProyectil : MonoBehaviour
{
    public GameObject Proyectil;
    public float tiempoEntreProyectil = 0;
    public float tiempoTotal = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.transform.rotation);
        tiempoTotal += Time.deltaTime;
        if (Input.GetButton("Fire1") && tiempoTotal >= tiempoEntreProyectil)
        {
            Instantiate(Proyectil, this.transform.position, this.transform.rotation);
            tiempoTotal = 0;
        }
    }
}
