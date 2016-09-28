using UnityEngine;
using System.Collections;

public class spiker : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D spikerRigidBody;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			if(GameObject.Find("controllerCollider").GetComponent<Player>().facingRight == false) {
            GameObject.Find("controllerCollider").GetComponent<Player>().spikerHurt();
			spikerRigidBody.AddForce(new Vector3(-200,200,0));
			GameObject.Find("controllerCollider").GetComponent<Player>().MyRigidbody.AddForce(new Vector3(300,300,0));
		}
			if(GameObject.Find("controllerCollider").GetComponent<Player>().facingRight == true) {
			GameObject.Find("controllerCollider").GetComponent<Player>().spikerHurt();
			spikerRigidBody.AddForce(new Vector3(200,200,0));
			GameObject.Find("controllerCollider").GetComponent<Player>().MyRigidbody.AddForce(new Vector3(-300,300,0));
		}
	}
	}
}
