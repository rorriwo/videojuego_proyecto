using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 5;
    private int direccion = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 7);
        if (GameObject.FindGameObjectWithTag("Player").transform.localScale.x > 0)  
        {
            this.transform.localScale = new Vector3(1, 1, 1);
            direccion = 1;
        }
        else if (GameObject.FindGameObjectWithTag("Player").transform.localScale.x < 0)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
            direccion = -1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);
        
        

        
    }
}
