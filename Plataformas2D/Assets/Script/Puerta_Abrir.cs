using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta_Abrir : MonoBehaviour
{
    public static bool tomada = false;
    Animator anim;
    bool dentro = false;
    bool Puerta = false;
    
    void Start()
    {
        anim = GetComponent<Animator>();
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
        if (dentro && Input.GetKeyDown(KeyCode.F) && tomada)
        {
            Puerta = true;
        }

        if (Puerta)
        {
            anim.SetTrigger("Abrir");
        }

    }
}
