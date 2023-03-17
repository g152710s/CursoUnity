using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioInfierno : MonoBehaviour
{
    public bool PasarNivel = false;
    public int InfiernoNivel;
    private Animator Transicion;

    void Start()
    {
        Transicion = GetComponentInChildren<Animator>();
    }


    void Update()
    {

        if (PasarNivel)
        {
            CambiarNivel(InfiernoNivel);
        }
    }

    public void CambiarNivel(int Cielo)
    {

        StartCoroutine(SceneLoad(2));

    }

    private void OnTriggerEnter(Collider other)
    {

        PasarNivel = true;

    }

    public IEnumerator SceneLoad(int SceneIndex)
    {

        Transicion.SetTrigger("EmpiezaLaTransición");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);

    }
}