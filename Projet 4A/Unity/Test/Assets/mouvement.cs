using UnityEngine;
using System.Collections;

public class mouvement : MonoBehaviour {

	public float speed = 0.3f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space))
			transform.Translate(new Vector3(0,speed,0));
		if (Input.GetKey (KeyCode.D))
			transform.Translate(new Vector3(speed,0,0));
		if (Input.GetKey (KeyCode.Q))
			transform.Translate(new Vector3(-speed,0,0));
	}

	public void haut()
	{
			transform.Translate(new Vector3(0,0.4f,0));
	}
}
