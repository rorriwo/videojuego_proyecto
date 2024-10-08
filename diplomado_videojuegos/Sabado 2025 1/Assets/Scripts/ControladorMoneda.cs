using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMoneda : MonoBehaviour
{
    public GameObject[] monedas;
    
    // Start is called before the first frame update
    void Start()
    {
        monedas = GameObject.FindGameObjectsWithTag("Moneda");

        for (int i = 0; i < monedas.Length; i++)
        {
            
            PlayerPrefs.SetInt(monedas[i].name, 1);
            Debug.Log(monedas[i].name + ": " + PlayerPrefs.GetInt(monedas[i].name));
        }
        for(int i = 0;i< monedas.Length; i++)
        {
            if(PlayerPrefs.GetInt(monedas[i].name) == 0)
            {
                Destroy(monedas[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(monedas[0].name);
        Debug.Log(monedas[1].name);
    }
}
