using UnityEngine;
using System.Collections;

public class Break_forLB_A : MonoBehaviour {

public bool signA;

	// Use this for initialization
	void Start () {
		signA = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Longboard_after_039").gameObject;
		GameObject AconeB = transform.FindChild("Longboard_after_016").gameObject;
		GameObject AconeC = transform.FindChild("Longboard_after_001").gameObject;
		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(2, 0, 2, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(0, 0, 2, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;

			fragment.SetActive(true);
			signA = true;
			}
		}catch(System.Exception e){}
	}
}