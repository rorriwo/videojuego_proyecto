using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecconParedes : MonoBehaviour
{
    private MovePlayer1 mp;
    // Start is called before the first frame update
    void Start()
    {
        mp = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pared") || collision.CompareTag("Suelo"))
        {
            mp.deslizando = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pared") || collision.CompareTag("Suelo"))
        {
            mp.deslizando = false;
        }   
    }
    
}
