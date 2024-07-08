using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 30;
    private int currentHealth;

    Ships _shipsClass;

    private void Start()
    {
        FindObjectOfType<Ships>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        if(currentHealth <= 0) 
        {
            Destroy(_shipsClass.shipObject);
        }
    }

    public int GetCurrentHealth() 
    {
        return currentHealth;
    }
}
