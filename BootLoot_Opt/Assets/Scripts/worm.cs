using UnityEngine;
using System.Collections;

public class worm : MonoBehaviour {

	[SerializeField]
	private bool facingRight = false;
	
	[SerializeField]
	private float speed;

	[SerializeField]
	private Vector3 direction;

	private Rigidbody2D WormRigidBody;
	[SerializeField]
	public Animator WormAnimator;

	// Use this for initialization
	void Start () {

		StartCoroutine (moveTimer ());

		WormRigidBody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (WormRigidBody.velocity.y < 0f) {
			WormAnimator.SetBool ("falling", true);
		} else {
			WormAnimator.SetBool ("falling", false);
		}

		if (facingRight == false) {
			direction = new Vector3(-1,0,0);
			transform.localScale = new Vector3(transform.localScale.x * 1, 2, 1);
		} else if (facingRight == true) {
			direction = new Vector3(1,0,0);
			transform.localScale = new Vector3(transform.localScale.x * -1, 2, 1);
		}
	
	}

	public IEnumerator jumpDead() {
		WormAnimator.SetTrigger ("dead");
		yield return new WaitForSeconds (1);
		Debug.Log ("Spawn gem");
	}

    public void wormDestroy()
    {
        Destroy(gameObject);
    }

	private IEnumerator moveTimer() {
		yield return new WaitForSeconds (2.40f);
		WormAnimator.SetTrigger ("moving");
		transform.Translate (Vector3.left * (2 *Time.deltaTime));
		//Move ();
	}

	public void Move() {
		transform.Translate (Vector3.left * (2 *Time.deltaTime));
		Debug.Log ("Should be moving");
	}

	public void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Edge") {
			ChangeDirection ();
			Debug.Log ("Should have changed direction");
		}
	}

	public virtual void ChangeDirection(){
		if (facingRight == false) {
			facingRight = true;
		} else if (facingRight == true) {
			facingRight = false;
		}
	}

}
