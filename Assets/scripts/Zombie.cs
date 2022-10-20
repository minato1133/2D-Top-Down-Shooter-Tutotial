using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	// Start is called before the first frame update
	Transform Shooter;
	Vector2 dir;
	Rigidbody2D rb;
	public float speed = 2f;
	public GameObject zombiePrefab;
	GameObject Player;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("Spawn",7f,1);
		rb = GetComponent<Rigidbody2D>();
		Player = GameObject.Find("Shooter");
		if(Player!=null)
		Shooter = Player.transform;
	}
	void Spawn()
	{
		Player = GameObject.Find("Shooter");
		if (Player == null)
			return;
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
	void Update()
	{
		if (Shooter)
			dir = (Shooter.position - transform.position).normalized;

	}
	// Update is called once per frame
	void FixedUpdate()
	{
		Player = GameObject.Find("Shooter");
		if (Player==null)
        {
			rb.velocity = Vector2.zero;

		}
        else
        {
			rb.velocity = dir * speed;

			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			rb.rotation = angle;
		}
	
	}
	
	
}
