using UnityEngine;

public class SoldierController : MonoBehaviour {

	private SoldierPawn soldierPawn;

	void Start () {
		soldierPawn = GetComponent<SoldierPawn> ();
	}

	void Update () {
		if (!soldierPawn.isActing ()) {
			Process();
		}
	}

	string Process() {
		return "Speak";
	}
}
