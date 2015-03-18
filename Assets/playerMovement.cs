using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	private Rigidbody2D body;
	public float acceleration;
	public float maxSpeed;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () { }

	// All Physics go here
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			body.AddForce( Vector2.right * -acceleration );
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			body.AddForce( Vector2.right * acceleration );
		}
		body.velocity = Vector2.ClampMagnitude (body.velocity, maxSpeed);
	}
}
