using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
	public int score;
	public GameObject text;
	// Use this for initialization


	// Update is called once per frame
	void Update () {
		text.GetComponent<Text> ().text = score + "";
	}
}