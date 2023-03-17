using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public float fireRate = 1f;
    public float attackRange = 10f;
    public Transform player;

    private float timeSinceLastAttack = 0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    { 
        float distanceToPlayer = Mathf.Abs(transform.position.x - player.position.x);
        //Debug.Log(distanceToPlayer);
        if (distanceToPlayer <= attackRange)
        {
            timeSinceLastAttack += Time.deltaTime;
            if (timeSinceLastAttack >= 1f / fireRate)
            {
                LaunchProjectile();
                timeSinceLastAttack = 0f;
            }
        }
    }

    void LaunchProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Vector2 direction = (player.position - transform.position).normalized;
        projectile.GetComponent<Rigidbody>().velocity = direction * projectileSpeed;
    }
}

