using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	private Rigidbody2D body;
	public float acceleration;
	public float maxSpeed;
	public float xFlipSpeed = 1f; 

	private int dirX = -1; // -1 left, 1 right; movement direction
	private int inputMoveX = 0;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) { // this works for touching mobile thing too
			if(Input.mousePosition.x > Screen.width * 0.5f){
				inputMoveX = 1;	
			}else{
				inputMoveX = -1;
			}
		}else if (Input.GetKey (KeyCode.LeftArrow)) {
			inputMoveX = -1;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			inputMoveX = 1;
		} else {
			inputMoveX = 0;
		}
	}
	
	// All Physics go here
	void FixedUpdate () {
		if (inputMoveX != 0) {
			body.AddForce (Vector2.right * acceleration * inputMoveX);
		}

		body.velocity = Vector2.ClampMagnitude (body.velocity, maxSpeed);

		if (Mathf.Abs (body.velocity.x) > 1)
		{
			dirX = body.velocity.x > 0 ? -1 : 1;
		}

		float scaleXCur = transform.localScale.x + (Time.deltaTime * xFlipSpeed * dirX);
		transform.localScale = new Vector3 (Mathf.Clamp(scaleXCur,-1,1),1,1);
	}
}
