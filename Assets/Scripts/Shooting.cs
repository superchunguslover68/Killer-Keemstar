using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class Shooting : MonoBehaviour {
	
	public GameObject Bullet;
	public GameObject Shootin;
	void FixedUpdate(){
		if (Input.GetMouseButtonDown (0) && Shootin.GetComponent<AmmoManager>().ammo>0){
			Shootin.GetComponent<AmmoManager> ().ammo--;
			Instantiate (Bullet, transform.position, transform.rotation);


	}

}
}