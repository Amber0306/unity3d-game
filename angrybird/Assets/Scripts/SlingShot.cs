using UnityEngine;
using System.Collections;

public class SlingShot : MonoBehaviour {

	private bool Clicked;
	public GameObject ammo;
	private GameObject shot;
	private Vector3 lastKnownPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool bIsButtonDown = Input.GetButton("Fire1");
		if (!Clicked)
		{
			if (bIsButtonDown)
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit rch;
				if (GetComponent<Collider>().Raycast(ray,out rch, 1000.0f))
				{
					Clicked = true;
					// 创建弹药
					if (null!=shot)
					{
						shot.tag = "LastShot";
					}
					shot = Instantiate(ammo, transform.position, Quaternion.identity) as GameObject;
					Physics.IgnoreCollision(shot.GetComponent<Collider>(), GetComponent<Collider>());
					shot.GetComponent<Rigidbody>().isKinematic = true;
				}
				else if (null!=shot) // 发射
				{
					// 清空
					shot.tag = "LastShot";
					shot = null;
				}
			}
		}
		else if (bIsButtonDown)//拉动弹弓
		{
			Vector3 cameraWorldZ = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
			lastKnownPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
			                                                               -cameraWorldZ.z));
			
			//计算打击方向
			Vector3 direction = transform.position - lastKnownPosition;
			direction.Normalize();
			float magnitude = Mathf.Min(Vector3.Distance(transform.position, lastKnownPosition),2.0f);
			shot.transform.position = transform.position + direction * -magnitude;
		}
		else
		{
			// 计算方向
			Vector3 direction = transform.position - lastKnownPosition;
			float magnitude = Mathf.Min(Vector3.Distance(transform.position, lastKnownPosition),2.0f);
			shot.GetComponent<Rigidbody>().isKinematic = false;
			direction.Normalize();

			shot.transform.position = transform.position;
			shot.GetComponent<Rigidbody>().velocity = direction * 10.0f * magnitude;
			Clicked = false;
			shot.tag = "Shot";
			shot.GetComponent<PlaAmmo>().HasBeenShot = true;


		}

		
	}
}
