using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje2DProyecto : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController characterController;

    float direccionHorizontal;
    float direccionVertical;
    Vector3 movimiento = Vector3.zero;
    float velocidad = 5f;
    float gravedad = 10f;
    float salto = 3f;

    int contadorDobleSalto = 0;
   

    //Animator anim = null;

    //AudioSource audioSource = null;

    float fuerzaGravedad = 0;
    //float duracionSalto = 0;
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    internal void sueloAnimacion()
    {
        //anim.SetBool("Suelo 0", true);
    }

    //public void ReproducirSonido()
    //{
    //    audioSource.Play();
    //}


    public void Salto()
    {
        //duracionSalto = 0;
        fuerzaGravedad = -salto;
        contadorDobleSalto = contadorDobleSalto + 1;
        //ReproducirSonido();
        //anim.SetTrigger("Salto");
    }

    public void DobleSalto()
    {
        //duracionSalto = 0;
        fuerzaGravedad = 2 * (-salto/3);
        contadorDobleSalto = contadorDobleSalto + 1;
        //ReproducirSonido();
        //anim.SetTrigger("Salto");
    }


    void Update()
    {
        //duracionSalto = duracionSalto + Time.deltaTime;
        direccionHorizontal = Input.GetAxis("Horizontal");
        direccionVertical = Input.GetAxis("Vertical");

        //if (direccionVertical > 0.1f)
        //{
        //    anim.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        //}
        //else
        //{
        //    if (direccionVertical < -0.1f)
        //    {
        //        anim.transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        //    }
        //}

        //if (direccionHorizontal > 0.1f)
        //{
        //    anim.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        //}
        //else
        //{
        //    if (direccionHorizontal < -0.1f)
        //    {
        //        anim.transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
        //    }
        //}

        //anim.SetFloat("Blend", Mathf.Abs(direccionHorizontal));
        if (characterController.isGrounded)
        {
            fuerzaGravedad = 1;
            contadorDobleSalto = 0;
        }

        if (contadorDobleSalto == 0)
        {
            //anim.SetBool("Suelo 0", true);
            if (Input.GetButtonDown("Jump"))
            {
                //Debug.Log("salto");
                //duracionSalto = 0;

                Salto();
            }
        }
        else
        {
            if (contadorDobleSalto == 1)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    //Debug.Log("salto");
                    //duracionSalto = 0;

                    DobleSalto();
                }
            }
            //anim.SetBool("Suelo 0", false);
        }

        //if (Input.GetButtonUp("Jump"))
        //{
        //    if (duracionSalto < 0.3f)
        //    {
        //        fuerzaGravedad = fuerzaGravedad / 2;
        //    }
        //}
        movimiento.x = direccionHorizontal;

        fuerzaGravedad = fuerzaGravedad + gravedad * Time.deltaTime;

        movimiento.y = -fuerzaGravedad;

        characterController.Move(movimiento * Time.deltaTime * velocidad);
    }
}
