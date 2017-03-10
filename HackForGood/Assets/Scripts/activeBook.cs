using UnityEngine;

public class activeBook : MonoBehaviour {

    private Animator anim;
    private conversationLaunch converLaunch;

    public GameObject flujoConver;

	void Start () {
        this.anim = this.gameObject.GetComponent<Animator>();
        this.converLaunch = this.flujoConver.GetComponent<conversationLaunch>();
	}

    public void activeBorrar()
    {
        this.anim.SetBool("Borrar", true);
    }

    public void activeAbsorber()
    {
        this.anim.SetBool("Absorber", true);
    }

    public void lanzarSegundaConver()//Lanzada desde la animacion del libro
    {
        this.converLaunch.launchSecondConversation();
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