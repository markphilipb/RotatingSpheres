using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivotsphere : MonoBehaviour {
	public GameObject pivot;
	// Use this for initialization
	void Start () {
		Instantiate(pivot, new Vector3(0, 0, 0), transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(pivot.transform.position, Vector3.forward, Time.deltaTime*100);

	}
}
