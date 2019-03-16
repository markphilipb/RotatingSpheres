using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbehout : MonoBehaviour {

public GameObject sp1;
	// Use this for initialization
	void Start () {
		
		for(int i=0; i<12; i++){
			float t = i * 2 * Mathf.PI / 12;
			float x = Mathf.Sin(t) * 15;
			float y = Mathf.Cos(t) * 15;
       	    sp1.transform.position = new Vector3(x, y, 0);
			Instantiate(sp1, sp1.transform.position, transform.rotation);
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
