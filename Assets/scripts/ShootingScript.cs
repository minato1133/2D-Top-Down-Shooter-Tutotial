using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float timeTowait = 0.2f;
    float timeInSec = 0f;
    void Update()
    {
        timeInSec += Time.deltaTime;

        if (Input.GetMouseButton(0) && timeInSec > timeTowait)
        {
            Shoot();
            timeInSec = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.transform.rotation = firePoint.transform.rotation;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }

   
    
     
}

