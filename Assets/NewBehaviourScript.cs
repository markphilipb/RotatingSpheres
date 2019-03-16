using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject sp;
	// Use this for initialization
	void Start () {
		
		for(int i=0; i<12; i++){
			float t = i * 2 * Mathf.PI / 12;
			float x = Mathf.Sin(t) * 10;
			float y = Mathf.Cos(t) * 10;
       	    sp.transform.position = new Vector3(x, y, 0);
			Instantiate(sp, sp.transform.position, transform.rotation);
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
