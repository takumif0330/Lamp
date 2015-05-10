using UnityEngine;
using System.Collections;

public class Break_forLB_E : MonoBehaviour {

public bool signE = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Longboard_after_021").gameObject;
		GameObject AconeB = transform.FindChild("Longboard_after_020").gameObject;
		GameObject AconeC = transform.FindChild("Longboard_after_019").gameObject;
		GameObject AconeD = transform.FindChild("Longboard_after_018").gameObject;
		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");
			AconeD.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeD.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;
			AconeD.transform.parent = null;

			fragment.SetActive(true);
			signE = true;
			}
		}catch(System.Exception e){}
	}
}