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

		if (Mathf.Abs (body.velocity.x) > 1)
		{
			float direction = body.velocity.x > 0 ? -1 : 1;
			transform.localScale = new Vector3 (direction,1,1);
		}
	}
}
