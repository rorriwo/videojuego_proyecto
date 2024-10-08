using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCama : MonoBehaviour
{
    private GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        if (PlayerPrefs.HasKey("PlayX"))
        {
            jugador.transform.position = new Vector2(PlayerPrefs.GetFloat("PlayX"), PlayerPrefs.GetFloat("PlayY"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            PlayerPrefs.DeleteKey("PlayX");
            PlayerPrefs.DeleteKey("PlayY");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetFloat("PlayX", collision.transform.position.x);
            PlayerPrefs.SetFloat("PlayY", collision.transform.position.y);
        }
    }
}