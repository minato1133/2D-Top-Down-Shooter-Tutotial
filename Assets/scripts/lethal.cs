using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lethal : MonoBehaviour
{
    public float damage;
    public string enemyTag;
    
    void Start()
    {
        
    }
   

    public void  OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy tag")
        {
           other.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
