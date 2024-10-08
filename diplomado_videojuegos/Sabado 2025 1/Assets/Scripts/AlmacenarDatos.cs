using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//No se recomienda utilizar PlayerPrefs porque solo almacena datos planos; no tiene capas de seguridad para guardar usuarios o datos importantes
public class AlmacenarDatos : MonoBehaviour
{
    public TMP_InputField inField;

    public void almacenarDatos()
    {
        PlayerPrefs.SetString("Texto Guardado", inField.text);
    }

    public void cargarDatos()
    {
        if (PlayerPrefs.HasKey("Texto Guardado"))
        {
            inField.text = PlayerPrefs.GetString("Texto Guardado");
        }
        else
        {
            inField.text = "Sin datos guardado";
        }
    }

    public void borrarDatos()
    {
        PlayerPrefs.DeleteKey("Texto Guardado");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
