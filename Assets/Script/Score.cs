using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


 	void OnBecameInvisible () {

		GUI.Label (new Rect (0.50f, Screen.width, Screen.height - 50.0f, 30.0f), "You loose");
		}



	public void Restart () {
		Application.LoadLevel ("Level");

	}


}
