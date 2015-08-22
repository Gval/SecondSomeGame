using UnityEngine;
using System.Collections;

public abstract class Condition : MonoBehaviour {
	
	[SerializeField]
	public GameObject obj;

	[SerializeField]
	public GameObject myObj;

	public abstract bool CompareObject();
}
