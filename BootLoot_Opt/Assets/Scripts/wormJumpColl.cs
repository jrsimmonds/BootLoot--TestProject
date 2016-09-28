using UnityEngine;
using System.Collections;

public class wormJumpColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			GameObject.Find("Player").GetComponent<Player>().MyRigidbody.AddForce(new Vector2(0,1000));
			gameObject.GetComponentInParent<worm> ().WormAnimator.SetTrigger ("dead");
		}
	}
}
