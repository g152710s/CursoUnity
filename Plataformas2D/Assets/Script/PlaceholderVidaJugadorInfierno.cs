using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderVidaJugadorInfierno : MonoBehaviour
{
    [SerializeField] Transform checkpoint3;
    [SerializeField] Transform checkpoint4;
    [SerializeField] Transform checkpoint5;
    int checkpointActivo;
    int vidaJugador = 3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Test
        if (Input.GetKeyDown("r"))
        {
            vidaJugador = 0;
            Debug.Log("r");
        }

        if (vidaJugador == 0)
        {           
           RespawnJugador();
        }
    }

    public void RespawnJugador()
    {
        switch (checkpointActivo)
        {          
            case 3: transform.position = checkpoint3.position; vidaJugador = 3; break;
            case 4: transform.position = checkpoint4.position; vidaJugador = 3; break;
            case 5: transform.position = checkpoint5.position; vidaJugador = 3; break;
        }
    }

    public void ActivarCheckpoint3()
    {
        checkpointActivo = 3;
        Debug.Log("3");
    }

    public void ActivarCheckpoint4()
    {
        checkpointActivo = 4;
        Debug.Log("4");
    }

    public void ActivarCheckpoint5()
    {
        checkpointActivo = 5;
        Debug.Log("5");
    }

}
