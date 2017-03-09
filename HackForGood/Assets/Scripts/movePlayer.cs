using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	public float speed = 1f;
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("DPADX") == -1))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("DPADX") == 1))
        {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow) || (Input.GetAxis("DPADY") == -1))
        {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow) || (Input.GetAxis("DPADY") == 1))
        {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}