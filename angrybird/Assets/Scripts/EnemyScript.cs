using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float damageThreshold;//伤害值
	public GameObject deathParticle;
	private float health;
	private bool Falling;
	// Use this for initialization
	void Start () {
		health = 1.0f;	
		Falling=false;
	}

	void FixedUpdate() {
		if (health <= 0.0f)
		{
			Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);

			Destroy(gameObject);
		}
		if (!Physics.Raycast(gameObject.transform.position, Vector3.down, 1.0f))
		{
			Falling = true;
		}
		else if (GetComponent<Rigidbody>().velocity.y<=-1.3f)
		{
			Falling = true;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		float mass = (collision.rigidbody==null) ? 0.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (Falling||collision.gameObject.CompareTag("Shot"))
		{
			health-=1.1f;
		}
		else if (impactAmount > damageThreshold)
		{
			health-=0.55f;
		}
	}
	void OnCollisionStay(Collision collision)
	{
		float mass = (collision.rigidbody==null) ? 0.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (collision.gameObject.CompareTag("Shot"))
		{
			health-=1.1f;
		}
		else if (impactAmount > damageThreshold)
		{
			health-=0.55f;
		}
	}
}


