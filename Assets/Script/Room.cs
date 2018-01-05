using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

	public Transform PositionPerso;
	public GameObject Ground;
	public GameObject GroundClone;

	public float PositionX;
	public float PositionY;

	public Random Aleatoire;

	// Use this for initialization
	void Start () {
		
		PositionPerso = GameObject.Find ("Character").transform;
        /*
		PositionX = Random.Range (-4.0f, 4.0f);
		PositionY = Random.Range ((this.transform.position.y) - 3.0f, (this.transform.position.y) - 2.0f);

		GroundClone = Instantiate (Ground, new Vector2 (PositionX,PositionY), Quaternion.identity) as GameObject;
		GroundClone.transform.parent = this.transform.parent;

		PositionX = Random.Range (-4.0f, 4.0f);
		PositionY = Random.Range ((this.transform.position.y) - 2.0f, (this.transform.position.y)-1.0f);

		GroundClone = Instantiate (Ground, new Vector2 (PositionX,PositionY), Quaternion.identity) as GameObject;
		GroundClone.transform.parent = this.transform.parent;

		PositionX = Random.Range (-4.0f, 4.0f);
		PositionY = Random.Range ((this.transform.position.y) -1.0f, (this.transform.position.y));

		GroundClone = Instantiate (Ground, new Vector2 (PositionX,PositionY), Quaternion.identity) as GameObject;
		GroundClone.transform.parent = this.transform.parent;

		PositionX = Random.Range (-4.0f, 4.0f);
		PositionY = Random.Range ((this.transform.position.y) , (this.transform.position.y) + 2.0f);

		GroundClone = Instantiate (Ground, new Vector2 (PositionX,PositionY), Quaternion.identity) as GameObject;
		GroundClone.transform.parent = this.transform.parent;

		PositionX = Random.Range (-4.0f, 4.0f);
		PositionY = Random.Range ((this.transform.position.y) +2.0f, (this.transform.position.y) + 4.0f);

		GroundClone = Instantiate (Ground, new Vector2 (PositionX,PositionY), Quaternion.identity) as GameObject;
		GroundClone.transform.parent = this.transform.parent;
        */

	}



	void OnBecameInvisible () {
		if (this.transform.position.y < PositionPerso.position.y ) {
			Destroy (this.transform.parent.gameObject);
		}
	}

}
