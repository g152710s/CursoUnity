using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int danio = 1;
    public float tiempoVidaProyectil = 0.5f;

    public GameObject efecto;
    public ContactPoint contacto;
    public Quaternion rot;
    public Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempoVidaProyectil -= Time.deltaTime;
        if (tiempoVidaProyectil <= 0)
        {
            Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SaludPlayer saludPlayer = other.GetComponent<SaludPlayer>();
            if (saludPlayer != null)
            {
                saludPlayer.HazDanio(danio);
                
            }
        }
        Instantiate(efecto, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
        Destroy(gameObject);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == )
    //    {

    //    }
    //    contacto = collision.contacts[0];
    //    rot = Quaternion.FromToRotation(Vector3.up, contacto.normal);
    //    pos = contacto.point;
    //    Instantiate(efecto, pos, rot);
    //    Destroy(gameObject);
    //}
}
