using UnityEngine;
using System.Collections;

public class appl : MonoBehaviour {
	string Card;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Card = Application.loadedLevelName;	
	}
	void OnClick(){
		Application.LoadLevel (Card);
	}
}
