using UnityEngine;
using System.Collections;

public class SoldierPawn : MonoBehaviour {

	bool act = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Speak() {
		Debug.Log ("Oy Mate");
	}

	public bool isActing() {
		return act;
	}
}
