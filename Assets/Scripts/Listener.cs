using UnityEngine;
using System.Collections;

public class Listener : MonoBehaviour {
	public GameObject thisObject;
	[SerializeField] public float[] yearsInactive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void receiveMessage(float year){
		Debug.Log ("Inside rec message");

		thisObject.SetActive (true);
		for (int i = 0; i < yearsInactive.Length; i++) {
			if (year == yearsInactive [i]){
				Debug.Log ("Setting fridge inactive");
				thisObject.SetActive (false);
			}
			
		}
	}
}
