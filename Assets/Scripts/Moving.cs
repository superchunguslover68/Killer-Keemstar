using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

	public float speed = 1f;
	public float timeToLive = 2f;

	private float startTime;

	void Start(){
		startTime = Time.realtimeSinceStartup;
	}

	// Update is called once per frame
	void Update(){

		//this will delete the game object after a set amount of time
		if (Time.realtimeSinceStartup >= startTime + timeToLive) {
			Destroy (gameObject);
			Destroy (this);
		}
	}

	void FixedUpdate () {
		//this will shoot the projectile forward
		transform.Translate (Vector3.forward * speed);
	}
} 