using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MovePlayer1.modificadorVelocidad = 2;
            Invoke(nameof(restablecerVelocidad),5);
        }
    }

    private void restablecerVelocidad()
    {
        MovePlayer1.modificadorVelocidad = 1;
    }
}
