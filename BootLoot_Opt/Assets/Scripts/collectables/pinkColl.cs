using UnityEngine;
using System.Collections;

public class pinkColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			GameObject.Find("Globals").GetComponent<globals>().pinkCollTotal = GameObject.Find("Globals").GetComponent<globals>().pinkCollTotal + 1;
			Destroy (transform.parent.gameObject);
		}
	}
}
