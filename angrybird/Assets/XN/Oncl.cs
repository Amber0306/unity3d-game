using UnityEngine;
using System.Collections;

public class Oncl : MonoBehaviour {
	//定义face_1为按钮点击后要关闭的物体
	public GameObject face_1;
	//定义face_2为按钮点击后要调用打开的物体
	public GameObject face_2;

	// Use this for initialization
	void Start () {
	
	}
	void OnClick(){//print ("qw");
		face_1.active=false;
		face_2.active=true;
	}
}
