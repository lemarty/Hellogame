
using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {


	//follow accelerer
	public Rigidbody2D rb;      //Reference to Rigidbody Component
	public float speed;        //Speed, updated through script


	//follow smooth
	public float interpVelocity;
	public float minDistance;
	public float followDistance;
	public GameObject target;
	public Vector3 offset;
	Vector3 targetPos;

	//Floor count
	public int floor;


	// Use this for initialization
	void Start () {

		speed = 2f;
		target = GameObject.Find ("Character");
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = -transform.forward * speed;
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (target.transform.position.y > this.transform.position.y)
		{
			Vector3 posNoZ = transform.position;
			posNoZ.z = target.transform.position.z;

			Vector3 targetDirection = (target.transform.position - posNoZ);

			interpVelocity = targetDirection.magnitude * 5f;

			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime); 

			transform.position = Vector3.Lerp( transform.position, new Vector3 (this.transform.position.x,targetPos.y,targetPos.z) + offset, 0.25f);

		}
	}



	void Update() {



			}



}
