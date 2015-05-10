using UnityEngine;
using System.Collections;

public class Break_forBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider){
		GameObject Abar = transform.FindChild("after_parts").gameObject;
		GameObject Bbar = transform.FindChild("before_parts").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			Bbar.SetActive(false);
			Abar.SetActive(true);
		}
	}
}