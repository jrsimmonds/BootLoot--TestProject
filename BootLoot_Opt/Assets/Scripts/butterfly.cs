using UnityEngine;
using System.Collections;

public class butterfly : MonoBehaviour {

	private Vector3 posA;
	private Vector3 posB;
	private Vector3 nextPos;

	private bool facingRight = false;
	
	[SerializeField]
	private Transform childTrans;
	
	[SerializeField]
	private float speed;
	
	[SerializeField]
	private Transform transformB;

	private Rigidbody2D bRB;
	
	// Use this for initialization
	void Start () {
		posA = childTrans.localPosition;
		posB = transformB.localPosition;
		nextPos = posB;
		bRB = GameObject.Find ("Butterfly").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}
	
	private void Move() {
		childTrans.localPosition = Vector3.MoveTowards (childTrans.localPosition, nextPos, speed * Time.deltaTime);
		
		if (Vector3.Distance (childTrans.localPosition, nextPos) <= 0.1) {
			ChangeDest ();
			ChangeDirection();
		}
	}
	
	private void ChangeDest() {
		nextPos = nextPos != posA ? posA : posB;
	}


	public virtual void ChangeDirection()
	{
		//Changes the facingRight bool to its negative value
		facingRight = !facingRight;
		
		//Flips the character by changing the scale
		transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
	}
}
