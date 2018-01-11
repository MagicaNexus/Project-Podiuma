using UnityEngine;
using System.Collections;

public class colour : MonoBehaviour {
	private SpriteRenderer gc;
	// Use this for initialization
	void Start () {
		gc = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space))
			gc.color = Color.green;
		if (Input.GetKeyUp (KeyCode.Space))
			gc.color = Color.red;
		
	}
}
