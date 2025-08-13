using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject blletPrefab;
    public Transform firePoint;
    public float fireRate = 5f;
    private float nextFireTime;
    public float speed = 100f;

    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    private void Shoot()
    {
        GameObject arch = Instantiate(blletPrefab, firePoint.position, Quaternion.identity);
        arch.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(firePoint.right * -speed);
        //arch.transform.right = firePoint.right;
    }
}
