using UnityEngine;
using System.Collections;

public class haut : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MyFunction(string s)
	{
		string[] coordonnees;
		float[] xy = new float[2];
		coordonnees=s.Split(" ");
		xy[0] = Single.Parse(coordonnees[0]);
		xy[1] = Single.Parse(coordonnees[1]);

		if (Mathf.Sqrt (((xy [0] - 103) * (xy [0] - 103)) + ((xy [1] - 72) * (xy [1] - 72))) < 50) 
		{
			transform.Translate(new Vector3(-0.4f,0,0));
		}
		if (Mathf.Sqrt (((xy [0] - 251) * (xy [0] - 251)) + ((xy [1] - 72) * (xy [1] - 72))) < 50) 
		{
			transform.Translate(new Vector3(0.4f,0,0));
		}
		if (Mathf.Sqrt (((xy [0] - 1200) * (xy [0] - 1200)) + ((xy [1] - 72) * (xy [1] - 72))) < 50) 
		{
			transform.Translate(new Vector3(0,0.4f,0));
		}
			
	}
}
