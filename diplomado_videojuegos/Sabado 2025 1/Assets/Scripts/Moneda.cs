using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moneda : MonoBehaviour
{
    public static int contadorMoneda = 0;
    [SerializeField]
    [Range(0,100)]
    [Tooltip("Velocidad de giro de la moneda")]
    private float velocidadRotacion = 1;
    private TextMeshProUGUI mostradorMonedas;

    // Start is called before the first frame update
    void Start()
    {
        mostradorMonedas = GameObject.FindGameObjectWithTag("mostradorMonedas").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(contadorMoneda);

        transform.Rotate(new Vector3(0, 0, velocidadRotacion*Time.deltaTime)); //rotacion de objetos
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //ligar una accion con el player
        {
            //Debug.Log("Recolectaste una moneda");
            contadorMoneda++;
            mostradorMonedas.text = "Monedas: " + contadorMoneda;
            Destroy(this.gameObject,0.1f);
        }
    }
}
