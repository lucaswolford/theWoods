using UnityEngine;
using System.Collections;

public class dialogScript : MonoBehaviour {

	public GameObject[] npcs;
	public GameObject player;

	// Use this for initialization
	void Start () {
		// find by tag
		npcs = GameObject.FindGameObjectsWithTag("npc");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject npc in npcs){
			if (Mathf.Abs (npc.transform.position.x - player.transform.position.x) < 5)
				Debug.Log ("Close");
		}
	}
}
