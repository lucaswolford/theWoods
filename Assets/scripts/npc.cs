using UnityEngine;
using System.Collections;

public class npc : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		if (Mathf.Abs (transform.position.x - player.transform.position.x) < 5)
			Debug.Log ("Close");
	}
}
