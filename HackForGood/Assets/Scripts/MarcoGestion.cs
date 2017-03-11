using UnityEngine.UI;
using UnityEngine;

public class MarcoGestion : MonoBehaviour {

    public GameObject anio;
    public GameObject ciudad;

    private Animator anioAnim;
    private Animator ciudadAnim;

    void Start()
    {
        this.anioAnim = this.anio.GetComponent<Animator>();
        this.ciudadAnim = this.ciudad.GetComponent<Animator>();
    }

    public void ActivarAnio()
    {
        this.anioAnim.SetBool("Aparecer", true);
    }

    public void ActivarCiudad()
    {
        this.ciudadAnim.SetBool("Aparecer", true);
    }
}