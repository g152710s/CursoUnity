using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave_Agarrada : MonoBehaviour
{
    Renderer rend;
    bool dentro = false;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            dentro = true;
        }
    }


    void Update()
    {
        if (dentro)
        {
            Puerta_Abrir.tomada = true;
            rend.enabled = false;
        }
    }
}
