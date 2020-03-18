using UnityEngine;
using System.Collections;

public class WoodScript : MonoBehaviour {

	public float damageValue = 0.8f;
	private float health;
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		health = 1.0f;	
	}

	void FixedUpdate () 
	{
		if (health < 0.0f)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		AudioSource.PlayClipAtPoint(clip, transform.position);
		float mass = (collision.rigidbody==null) ? 0.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (impactAmount > damageValue)
		{
			health-=0.55f;
		}
	}
	void OnCollisionStay(Collision collision)
	{
		float mass = (collision.rigidbody==null) ? 0.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (impactAmount > damageValue)
		{
			health-=0.55f;
		}
	}
	void OnGUI()
	{
		return;
		Vector3 screenPos = Camera.current.WorldToScreenPoint(transform.position);
		GUI.Label(new Rect(screenPos.x, Screen.height-screenPos.y, 50,30), "H " + Mathf.RoundToInt(health*100));

	}	
}

