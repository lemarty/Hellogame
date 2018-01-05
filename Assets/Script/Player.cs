using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour {


	public float speed = 9f;
	public float jumpSpeed = 12f;
	private float movement = 0f;
	public bool IsGround;
    private Rigidbody2D rigidBody;

    public Transform transform;
    public bool Run;
    public Animator anim;
	public Rigidbody2D camera;
    public bool Jump;


	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		//Set object velocity
		camera = GameObject.Find ("Main Camera").GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {


        anim.SetBool("run",Run);
        anim.SetBool("jump", Jump);
        //Courir
        movement = Input.GetAxis ("Horizontal");
		rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);

        if (movement > 0f)
        {
            transform.localScale = new Vector3(3.37f, 2.94f, 1);
        }
        else if (movement < 0f)
        {
            transform.localScale = new Vector3(-3.37f, 2.94f, 1);
        }
      
        if (movement != 0)
        {
            Run = true;
        }
        else
        {
            Run = false;
        }
        

		//Sauter
		if(Input.GetButtonDown ("Jump") && IsGround ){
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
            Jump = true;

            //camera.velocity = new Vector2 (0, 2f);

  

        }

	}


}