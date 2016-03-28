using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Reset_Slider : MonoBehaviour {
	public Slider slider;
	// Use this for initialization
	void Start () {
		
	}
	
	public void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			slider.value = 2000.00f;
		}
	}
}
