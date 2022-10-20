using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zombie")
        {
            Debug.Log(col.collider.name);
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    }
    
