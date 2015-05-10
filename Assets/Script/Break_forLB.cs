using UnityEngine;
using System.Collections;

public class Break_forLB : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){

		GameObject Acone = transform.FindChild("AfterBoard").gameObject;
		GameObject Bcone = transform.FindChild("BeforeBoard").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			this.tag = "Untagged";
			Bcone.SetActive(false);
			Acone.SetActive(true);
		}
	}
}