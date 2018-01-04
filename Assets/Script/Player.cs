using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour {


	public float speed = 9f;
	public float jumpSpeed = 12f;
	private float movement = 0f;
	public bool IsGround;
	private Rigidbody2D rigidBody;

	public Rigidbody2D camera;


	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		//Set object velocity
		camera = GameObject.Find ("Main Camera").GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

		//Courir
		movement = Input.GetAxis ("Horizontal");
		rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);

		//Sauter
		if(Input.GetButtonDown ("Jump") && IsGround ){
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);

			//camera.velocity = new Vector2 (0, 2f);
						
		}

	}


}