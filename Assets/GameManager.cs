using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	private Animator cutscene_animator;
	void Start () {
		cutscene_animator = GameObject.Find("cutscene").transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	// void Update () {

	// 	cutscene_animator.SetTrigger("cut2");
		
	// }
}
