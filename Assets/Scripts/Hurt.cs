using UnityEngine;
using System.Collections;

public class Hurt : MonoBehaviour {
	public int lives = 3;

	// Use this for initialization
	void OnTriggerEnter(Collider c){

		if (c.gameObject.tag == "Enemy") {
			lives--;
		}
	}
}
