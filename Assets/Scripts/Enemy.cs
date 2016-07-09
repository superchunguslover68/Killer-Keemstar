using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public GameObject ScoreMan;
	public int killed = 0;
	public GameObject player;
	public float moveSpeed = .2f;
	void OnTriggerEnter(Collider c){

		if (c.gameObject.tag == "Bullet") {
			Debug.Log ("Alex");
			ScoreMan.GetComponent<ScoreManager> ().score++;
			GameObject.Destroy (this.gameObject);

		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		//This will move the object toward the player GameObject
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
	}
} 

