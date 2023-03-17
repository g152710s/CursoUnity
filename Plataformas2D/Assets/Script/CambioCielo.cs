using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioCielo : MonoBehaviour
{
    public bool PasarNivel = false;
    public int CieloNivel;
    private Animator Transicion;

    void Start()
    {
        Transicion = GetComponentInChildren<Animator>();
    }


    void Update()
    {

        if (PasarNivel)
        {
            CambiarNivel(CieloNivel);
        }
    }

    public void CambiarNivel(int Cielo)
    {

        StartCoroutine (SceneLoad(3));

    }

    private void OnTriggerEnter(Collider other)
    {

        PasarNivel = true;

    }

    public IEnumerator SceneLoad(int SceneIndex)
    {

        Transicion.SetTrigger("EmpiezaLaTransición");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);

    }
}
