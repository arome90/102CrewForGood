using UnityEngine;

public class activeBook : MonoBehaviour {

    private Animator anim;

	void Start () {
        this.anim = this.gameObject.GetComponent<Animator>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            this.anim.SetBool("Brillar", true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            this.anim.SetBool("Brillar", false);
        }
    }
}