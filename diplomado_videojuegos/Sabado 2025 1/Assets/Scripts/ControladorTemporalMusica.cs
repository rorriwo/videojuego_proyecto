using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTemporalMusica : MonoBehaviour
{
    public AudioSource audioS;// hace sonar el archivo de musica
    public AudioClip audioEfect; //este es el archivo de sonido
    public static ControladorTemporalMusica Instance;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            ControladorTemporalMusica instance = this;
            DontDestroyOnLoad(this.gameObject);  //para que la musica continue en el cambio de escenas
        }
        else
        {
            Destroy(this.gameObject);
        }

        
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))  //pausar musica
        {
            audioS.Pause();
        }
        if (Input.GetKeyDown(KeyCode.L))  //reproducir musica
        {
            audioS.Play();
        }
        if (Input.GetKeyDown(KeyCode.I))  //detener musica
        {
            audioS.Stop();
        }
        if (Input.GetKeyDown(KeyCode.M)) //intercambia la musica por el efecto
        {
            audioS.clip = audioEfect;
            audioS.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            audioS.PlayOneShot(audioEfect);  //para efectos de sonido sin interrumpir la musica
        }
    }
}
