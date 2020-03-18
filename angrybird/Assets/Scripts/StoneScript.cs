using UnityEngine;
using System.Collections;

public class StoneScript : MonoBehaviour {

	public float damageValue = 0.9f;
	public Material healthy_Mat;
	public Material h1_Mat;
	public Material h2_Mat;
	private float health;
	
	// Use this for initialization
	void Start () {
		health = 1.0f;	
	}
	
	// Update is called once per frame
	void Update () {
		Renderer rend = GetComponentInChildren<Renderer>();//获取渲染组件
		if (health > 0.7f)
		{
			rend.material = healthy_Mat;
		}
		else if (health > 0.3f)
		{
			rend.material = h1_Mat;
		}
		else
		{
			rend.material = h2_Mat;
		}
	}
	void FixedUpdate() {
		if (health < 0.0f)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{

		float mass = (collision.rigidbody==null) ? 0.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (impactAmount > damageValue)
		{
			health-=0.35f;
		}
	}
	void OnCollisionStay(Collision collision)
	{
		float mass = (collision.rigidbody==null) ? 1.0f : collision.rigidbody.mass;
		float impactAmount = collision.relativeVelocity.magnitude * 0.1f;
		if (impactAmount > damageValue)
		{
			health-=0.35f;
		}
	}

	void OnGUI()
	{

		return;
		if (health>0.0f)
		{
			Vector3 screenPos = Camera.current.WorldToScreenPoint(transform.position);
			GUI.Label(new Rect(screenPos.x, Screen.height-screenPos.y, 50,30), "H " + Mathf.RoundToInt(health*100));
		}

	}
}

