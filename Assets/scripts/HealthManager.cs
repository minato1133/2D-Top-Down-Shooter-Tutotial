using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    float health = 100f;
    public bool isDead = false;
   public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();

        }
    }
    void Die()
    {
        isDead = true;
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
