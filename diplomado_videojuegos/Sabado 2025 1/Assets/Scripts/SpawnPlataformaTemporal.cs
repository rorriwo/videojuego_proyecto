using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataformaTemporal : MonoBehaviour
{
    public GameObject PataformaTemporal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(PataformaTemporal, this.transform.position, this.transform.rotation);
        }
        
    }
}
