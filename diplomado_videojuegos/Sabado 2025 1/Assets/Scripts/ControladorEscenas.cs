using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioNivelUno()
    {
        SceneManager.LoadScene("Nivel_Uno");
    }

    public void CambioConfiguracion()
    {
        SceneManager.LoadScene("Configuraciones");
    }

    public void CambioMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void CambioEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

}
