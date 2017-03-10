using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class conversationLaunch : MonoBehaviour {

	private bool characterIn;
	public Text textoExplicativo;
	public string conversation;
	public Flowchart fc;
	// Use this for initialization
	void Start () {
		this.textoExplicativo.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (characterIn) {
			if (Input.GetKeyDown ("a") || Input.GetButtonDown("A Button")) {
				//Debug.Log (this.conversation);
				fc.ExecuteBlock (conversation);
                this.textoExplicativo.enabled = false;
			}
		}
	}


	void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Girl")
        {
            characterIn = true;
            this.textoExplicativo.enabled = true;
        }
    }

	void OnTriggerExit2D(Collider2D col) {
        if (col.tag == "Girl")
        {
            characterIn = false;
            this.textoExplicativo.enabled = false;
        }
	}
}
