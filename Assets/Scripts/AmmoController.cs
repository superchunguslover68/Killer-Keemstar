using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
public class AmmoController : MonoBehaviour {
	public GameObject AmmoMan;
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			AmmoMan.GetComponent<AmmoManager> ().ammo += 20;
			GameObject.Destroy (gameObject);


		}
	}
	void FixedUpdate(){


	}
}