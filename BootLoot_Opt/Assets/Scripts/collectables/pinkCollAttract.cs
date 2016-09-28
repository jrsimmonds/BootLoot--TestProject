using UnityEngine;
using System.Collections;

public class pinkCollAttract : MonoBehaviour {

	public Vector3 startPos;
	public Vector3 endPos;
	[SerializeField]
	private Rigidbody2D spikerRigidBody;

	private bool beingSucked;
	
	[SerializeField]
	private Transform coinTrans;
	[SerializeField]
	private Transform endTrans;
	
	public float speed;
	
	// Use this for initialization
	void Start () {
		endTrans = GameObject.Find ("Player").GetComponent<Transform> ().transform;
	}
	
	// Update is called once per frame
	void Update () {
		startPos = coinTrans.position;

		endPos = endTrans.position + new Vector3 (0, 2, 0);

		if (beingSucked) {
			spikerRigidBody.gravityScale = 0;
		} else {
			spikerRigidBody.gravityScale = 2;
		}
	}
	
	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "collSuck" && GameObject.Find ("Globals").GetComponent<globals> ().powerOn) {
			StartCoroutine (coinSuckTimer ());
			beingSucked = true;
		} else {
			beingSucked = false;
		}
	}
	
	private IEnumerator coinSuckTimer() {
		yield return new WaitForSeconds(0.25f);
		coinTrans.localPosition = Vector3.MoveTowards (coinTrans.localPosition, endPos, speed * Time.deltaTime);
	}
}
