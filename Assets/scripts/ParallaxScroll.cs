using UnityEngine;
using System.Collections;

public class ParallaxScroll : MonoBehaviour {	
	public float scrollSpeed;
	private float originalX;
	
	void Start () {
		originalX = transform.position.x;
	}
	
	void Update () {
		Vector3 cameraPosition = GameObject.Find("Wife").transform.position;

		var offsetX = cameraPosition.x / scrollSpeed;

		Vector3 theOffset = new Vector3 (offsetX + originalX, 0, 0);

		transform.position = theOffset;
	}
}

