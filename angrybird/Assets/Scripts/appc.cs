using UnityEngine;
using System.Collections;

public class appc : MonoBehaviour {
	public string card;
	// Use this for initialization
	void Start () {
	
	}

	void OnClick () {
		Application.LoadLevel (card);
	}
}
