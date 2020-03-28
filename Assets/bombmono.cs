using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombmono : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if(transform.position.y > -2.05f){
			transform.position -= new Vector3(0f,0.01f,0f);
		}
	}
}
