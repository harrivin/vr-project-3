using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class test : MonoBehaviour {
	public UnityEngine.UI.Slider slider;
	public float slider_val;
	public Text text;
	public float temp;
	public GameObject test_obj;
	public int x=10;
	public int y=1;
	public int z=10;
	public int cnt;
	public GameObject parent;
	[SerializeField] public GameObject[] GameObjectArray;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
		//slider = gameObject.GetComponent<Slider> ();

		//slider_val = slider.value;
		//parent.BroadcastMessage ("receiveMessage", 2001.00,SendMessageOptions.DontRequireReceiver);
		Cycle_obj(2000.00f);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			slider.value +=0.5f;
		}
		//slider_val = slider.value;

		//change_text (temp);

		//Debug.Log (slider_val);
	}

//	public void onValueChanged(float newval){
//		temp = slider_val;
//		change_text (temp);
//	}

	public void change_text(float temp){

		//parent.BroadcastMessage ("receiveMessage", temp,SendMessageOptions.DontRequireReceiver);
		Cycle_obj(temp);
		if (temp==2000.00) {
			cnt++;
			Debug.Log ("Inside change_Text");
			text.text = "30,556$";
			test_obj.transform.localScale = new Vector3 (35f,35f, 35f);
//			if (cnt < 2) {
//				for (int i = 0; i < 2; i++) {
//					x++;
//					y++;
//					z++;
//					Instantiate (test_obj, new Vector3 (255f + x, 10 + y, 160f + z), Quaternion.identity);
//				}
//			}
		}
		else if (temp==2001.00) {
			text.text = "2001--29,995$";
			test_obj.transform.localScale = new Vector3 (30f, 30f, 30f);

		}
		else if (temp==2002.00) {
			text.text = "2002--28,961$";
			test_obj.transform.localScale = new Vector3 (30f, 30f, 30f);

		}	
		else if (temp==2003.00) {
			text.text = "2003--29,901$";
			test_obj.transform.localScale = new Vector3 (32f, 32f, 32f);

		}
		else if (temp==2004.00) {
			text.text = "2004--30,350$";
			test_obj.transform.localScale = new Vector3 (35f, 35f, 35f);

		}
		else if (temp==2005.00) {
			text.text = "2005--30,943$";
			test_obj.transform.localScale = new Vector3 (35f, 35f, 35f);

		}
		else if (temp==2006.00) {
			text.text = "2006--30,605$";
			test_obj.transform.localScale = new Vector3 (38f, 38f, 38f);

		}
		else if (temp==2007.00) {
			text.text = "2007--29,649$";
			test_obj.transform.localScale = new Vector3 (32f, 32f, 32f);

		}
		else if (temp==2008.00) {
			text.text = "2008--29,274$";
			test_obj.transform.localScale = new Vector3 (30f, 30f, 30f);

		}
		else if (temp==2009.00) {
			text.text = "2009--28,838$";
			test_obj.transform.localScale = new Vector3 (28f, 28f, 28f);

		}
		else if (temp==2010.00) {
			text.text = "2010--29,005$";
			test_obj.transform.localScale = new Vector3 (27f, 27f, 27f);

		}
		else if (temp==2011.00) {
			text.text = "2011--29,161$";
			test_obj.transform.localScale = new Vector3 (27f, 27f, 27f);

		}
		else if (temp==2012.00) {
			text.text = "2012--29,301$";
			test_obj.transform.localScale = new Vector3 (30f, 30f, 30f);

		}else if (temp==2013.00) {
			text.text = "2013--30,518$";
			test_obj.transform.localScale = new Vector3 (35f, 35f, 35f);

		}
		else if (temp==2014.00) {
			text.text = "2014--30,176$";
			test_obj.transform.localScale = new Vector3 (35f, 35f, 35f);

		}
	}

	public void Cycle_obj(float temp){
		Debug.Log ("Size of array:"+GameObjectArray.Length);
		for (int i = 0; i < GameObjectArray.Length; i++) {
			GameObjectArray [i].SetActive (true);

		
		}
		parent.BroadcastMessage ("receiveMessage", temp);

	
	}


}
