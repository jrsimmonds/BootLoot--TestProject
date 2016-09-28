using UnityEngine;
using System.Collections;

public class wormSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject wormPreFab;
	[SerializeField]
	private Transform wormSpawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Y)) {
			GameObject.Find("wormSpawner").GetComponent<Animator>().enabled = true;
			Instantiate (wormPreFab, wormSpawnPoint.position, wormSpawnPoint.rotation);
		}
	}
}
