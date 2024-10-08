using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public GameObject puntoSalida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.T))
        {
            collision.transform.position = puntoSalida.transform.position;
        }
    }
    */

    //Input.GetKey(KeyCode.T)

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.T))
        {
            collision.transform.position = puntoSalida.transform.position;
        }
    }
}
