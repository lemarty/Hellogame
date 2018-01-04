using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {


	public GameObject Character;


	// Use this for initialization
	void Start () {

		Character = GameObject.Find ("Character");

		
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") {
			Application.LoadLevel ("Score");
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
