using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje2D : MonoBehaviour
{
    CharacterController characterController;
    Vector3 movimiento = Vector3.zero;
    [SerializeField] float direccionHorizontal;
    [SerializeField] float velocidad = 3f;
    [SerializeField] float gravedad = 9f;
    [SerializeField] float salto = 2f;
    float fuerzaGravedad = 0f;
    float duracionSalto = 0f;

    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {

        duracionSalto = duracionSalto + Time.deltaTime;
        direccionHorizontal = Input.GetAxis("Horizontal");
        if (characterController.isGrounded) 
        {
            fuerzaGravedad = 1f; 
            
            if (Input.GetButtonDown("Jump"))
            {
                Salto();
            }
        }
        fuerzaGravedad = fuerzaGravedad + gravedad * Time.deltaTime;
        movimiento.y = -fuerzaGravedad;
        movimiento.x = direccionHorizontal * Time.deltaTime * velocidad;
        characterController.Move(movimiento);
     }

    public void Salto()
    {
        fuerzaGravedad = -salto;
        duracionSalto = 0;
    }

    
}
