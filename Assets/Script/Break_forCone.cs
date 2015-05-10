using UnityEngine;
using System.Collections;

public class Break_forCone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider){
		GameObject Acone = transform.FindChild("AfterCone").gameObject;
		GameObject Bcone = transform.FindChild("BeforeCone").gameObject;
		GameObject Point = transform.FindChild("Point").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			Bcone.SetActive(false);
			Acone.SetActive(true);
			Point.SetActive(true);
		}
	}
}