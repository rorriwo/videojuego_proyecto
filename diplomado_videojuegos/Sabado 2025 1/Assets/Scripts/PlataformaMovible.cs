using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovible : MonoBehaviour
{
    public GameObject[] puntoDestino;
    public float velocidad = 1;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Vector2.Distance(this.transform.position, puntoDestino[indice].transform.position) < 0.3f)
        {
            indice++;
            if (indice >= puntoDestino.Length)
            {
                indice=0;

            }
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, puntoDestino[indice].transform.position, velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
