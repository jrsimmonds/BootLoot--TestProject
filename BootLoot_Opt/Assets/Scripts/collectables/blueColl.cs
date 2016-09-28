using UnityEngine;
using System.Collections;

public class blueColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			GameObject.Find("Globals").GetComponent<globals>().blueCollTotal = GameObject.Find("Globals").GetComponent<globals>().blueCollTotal + 1;
			Destroy (transform.parent.gameObject);
		}
	}
}
