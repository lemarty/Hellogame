using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {
	
	public Player Joueur;

	// Use this for initialization
	void Start () {

		Joueur = GetComponentInParent<Player> ();
	}
	


	//Check player Ground
	void OnTriggerEnter2D(Collider2D col)
	{
		Joueur.IsGround = true; 	
	}

	void OnTriggerStay2D(Collider2D col)
	{
		Joueur.IsGround = true;
        Joueur.Jump = false;
	}

	void OnTriggerExit2D(Collider2D col)
	{
		Joueur.IsGround = false; 
	}



}
