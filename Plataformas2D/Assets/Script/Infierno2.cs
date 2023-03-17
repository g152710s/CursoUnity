using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infierno2 : MonoBehaviour
{
    PlaceholderVidaJugadorInfierno vidaJugador;
    // Start is called before the first frame update
    void Start()
    {
        vidaJugador = GameObject.Find("PersonajeTest").GetComponent<PlaceholderVidaJugadorInfierno>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador2D")
        {
            vidaJugador.ActivarCheckpoint4();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
