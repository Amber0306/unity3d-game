using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public string Card;//跳转关卡的名字
	bool BOOL;
	public GameObject skyBackground;//天空背景
	public GameObject plantBackground;//近背景
	private GameObject bgInstance;//天空实例
	private GameObject ptInstance;//近背景实例
	private Vector3 slingShotPosition;//弹射位置
	private Vector3 furthestObjectivePosition;//最远目标的位置
	private float time;
	void Start () {
		BOOL = true;
		//bDebug=false;
		//获取位置信息
		slingShotPosition = gameObject.transform.position; // 相机定位
		// 获取最远的目标对象距离
		furthestObjectivePosition = Vector3.zero;
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Objective");
		foreach(GameObject go in gos)
		{
			if (go.transform.position.x > furthestObjectivePosition.x)
			{
				furthestObjectivePosition = go.transform.position;
			}
		}
		// 设置最大初始位置
		float x = furthestObjectivePosition.x;
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
		time = Time.time;

		if (null!=skyBackground)
		{
			bgInstance = Instantiate(skyBackground, new Vector3(x, transform.position.y, 100.0f), Quaternion.Euler(0, 0, 90)) as GameObject;
			bgInstance.transform.localScale = new Vector3(150.0f, 150.0f, 1.0f);
		}
		if (null!=plantBackground)
		{
			//ptInstance = Instantiate(plantBackground, GetMidBackgroundPosition(x), Quaternion.Euler(-90, 0, 0)) as GameObject;
			//ptInstance.transform.localScale = new Vector3(50.0f, 50.0f, 50.0f);
		}
	}

	// Update is called once per frame
	void Update () {
		GameObject shot = GameObject.FindWithTag("Shot");
		//检测怪死完,调用跳关
		if (GameObject.FindWithTag("Objective") == null && BOOL == true) {
			BOOL = false;
			StartCoroutine(Level());
		}
		if (null!=shot)
		{
			float x = Mathf.Max(shot.transform.position.x, slingShotPosition.x); 
			x = Mathf.Min(x, furthestObjectivePosition.x); 
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
			bgInstance.transform.position = new Vector3(x, transform.position.y, 100.0f);
			//ptInstance.transform.position = GetMidBackgroundPosition(x);
		}
		else if (Time.time-time > 1.5f)
		{
			// 移动回到发射点
			if (gameObject.transform.position.x > slingShotPosition.x)
			{
				float d = gameObject.transform.position.x - slingShotPosition.x;
				float x = gameObject.transform.position.x - 0.03f*d;
				transform.position = new Vector3(x, transform.position.y, transform.position.z);
				bgInstance.transform.position = new Vector3(x, transform.position.y, 100.0f);
				//ptInstance.transform.position = GetMidBackgroundPosition(x);
			}
		}
	}
	
	Vector3 GetMidBackgroundPosition(float x)
	{
		// 缩放到三分之一的水平运动的范围（从弹弓到最终的目标）
		float rx = furthestObjectivePosition.x - slingShotPosition.x;
		float dx = x - slingShotPosition.x;
		// 移动到距离的三分之一
		return new Vector3(dx/rx*0.3f + slingShotPosition.x, transform.position.y+10.0f, 50.0f);
	}
	IEnumerator Level(){
		yield return new WaitForSeconds(1.0f);
		Application.LoadLevel (Card);
		yield return 0;
	}
}
