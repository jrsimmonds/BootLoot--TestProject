using UnityEngine;
using System.Collections;

public class sparks : MonoBehaviour {

	public float waitTime;
	
	// Update is called once per frame
	void OnEnable () {
		waitTime = Random.Range (0f, 2f);
		StartCoroutine (animationTimer ());
	}

	IEnumerator animationTimer() {
		yield return new WaitForSeconds (waitTime);		
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		gameObject.GetComponent<Animator> ().enabled = true;
		yield return new WaitForSeconds (1);	
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<Animator> ().enabled = false;
		waitTime = Random.Range (0f, 2f);
		StartCoroutine (animationTimer ());
	}
}
