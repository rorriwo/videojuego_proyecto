using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public int vida = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida <= 0)
        {
            Debug.Log("Enemigo Morido");
            Destroy(this.gameObject, 0.2f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Proyectil"))
        {
            Destroy(collision.gameObject);
            vida--;
        }
    }
}
