using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject bulletObject;

    private void Start()
    {
        //rb.velocity = transform.up * bulletSpeed
    
    }
    
    

    private void Update()
    {
        rb.velocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ShipsTag")) 
        {
            //Destroy(bulletObject);
            gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
    }
}

