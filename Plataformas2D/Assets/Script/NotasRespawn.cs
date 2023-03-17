using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotasRespawn : MonoBehaviour
{
    int puntoRespawn;

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
            if (gameObject.tag == "RespawnTierra1")
            {
                puntoRespawn = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Esto era un test
        //if (Input.GetKeyDown("r"))
        //{
        //    puntoRespawn = 3;
        //    transform.position = respawnInfierno1.position;
        //}
    }

    //Este metodo MetodoRespawn() se llama desde el script que contenga la variable que siga la vida del jugador, para crear un if que cuando la vida llegue a 0, ejecute este metodo. En el mismo if, La vida deve ponerse a full justo despues del metodo para que deje de respawnear.
    public void MetodoRespawn()
    {
        Debug.Log("switch respawn");
        switch (puntoRespawn)
        {
            case 0: RespawnTierra1(); break;
            case 1: RespawnTierra2(); break;
            case 3: RespawnInfierno1(); break;
            case 4: RespawnInfierno2(); break;
            case 5: RespawnInfierno3(); break;
            case 6: RespawnCielo1(); break;
            case 7: RespawnCielo2(); break;
        }
    }
    public void RespawnTierra1()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnTierra2()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnInfierno1()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnInfierno2()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnInfierno3()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnCielo1()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }

    public void RespawnCielo2()
    {
        GameObject.FindGameObjectWithTag("Jugador2D").transform.position = transform.position;
    }
}
