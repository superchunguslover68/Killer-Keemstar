using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AmmoManager : MonoBehaviour {
	public int ammo;
	public GameObject text;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		text.GetComponent<Text> ().text = ammo + "";
	}
}
