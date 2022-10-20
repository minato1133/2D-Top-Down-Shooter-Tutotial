using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invokin : MonoBehaviour
{
    public GameObject zombiePrefab;

   
   
    void Start()
    {
       InvokeRepeating("Spawn", .50f, 1);

    }
    void Spawn()
    {
        Vector2 position = RandomCircle(Vector3.zero, 20);
        Instantiate(zombiePrefab, position, Quaternion.identity);
    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    
}
