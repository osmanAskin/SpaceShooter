using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour
{
    [SerializeField] private float shipSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int health = 30;
    [SerializeField] internal GameObject shipObject;

    Health _healthClass;

    private void Start()
    {
        FindObjectsOfType<Health>();
        rb.velocity = -transform.up * shipSpeed;
    }

    private void OnTriggerEnter2D(Collider2D current)
    {
        if (current.gameObject.CompareTag("BulletTag")) 
        {
            health--;

            if(health == 0) 
            {
                Destroy(shipObject);
            }
            //_healthClass.TakeDamage(3);
        }   
    }
}
