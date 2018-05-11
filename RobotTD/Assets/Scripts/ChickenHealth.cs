using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth =100;
    
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    
    public void TakeDamage(int damage)
    {
    currentHealth -= damage;
    if(currentHealth <=0)
        {
        currentHealth=0;
        print("you died");
        }
     }
    



	
	
	
}

