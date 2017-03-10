using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversationLaunch : MonoBehaviour {

	private bool characterIn;
	public Text textoExplicativo;
	public string conversation;
	// Use this for initialization
	void Start () {
		this.textoExplicativo.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (characterIn) {
			if (Input.GetKeyDown ("a")) {
				Debug.Log (conversation);
			}
		}
	}


	void OnTriggerEnter2D(Collider2D col) {
		characterIn = true;
		this.textoExplicativo.enabled = true;
	}

	void OnTriggerExit2D(Collider2D col) {
		characterIn = false;
		this.textoExplicativo.enabled = false;
	}
}
