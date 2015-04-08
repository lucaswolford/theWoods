using UnityEngine;
using System.Collections;

public class npcDialog : MonoBehaviour {

	public int dialogRange;

	private GameObject player;
	private Transform dialog;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		dialog = transform.FindChild ("dialog");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		if (Mathf.Abs (transform.position.x - player.transform.position.x) < dialogRange) {
			dialog.localScale = new Vector3(0.5f, 0.5f, 1.0f);
		} else {
			dialog.localScale = new Vector3(0, 0, 0);
		}
	}
}
