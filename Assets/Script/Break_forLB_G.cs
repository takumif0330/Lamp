using UnityEngine;
using System.Collections;

public class Break_forLB_G : MonoBehaviour {

public bool signG = false;

	GameObject AconeA;
	GameObject AconeB;
	GameObject AconeC;
	GameObject AconeD;
	GameObject AconeE;

	GameObject BoolObjA;
	GameObject BoolObjE;

	bool BoolA;
	bool BoolE;

	// Use this for initialization
	void Start () {
		AconeA = transform.FindChild("Longboard_after_030").gameObject;
		AconeB = transform.FindChild("Longboard_after_028").gameObject;
		AconeC = transform.FindChild("Longboard_after_029").gameObject;
		AconeD = transform.FindChild("Longboard_after_040").gameObject;
		AconeE = transform.FindChild("Longboard_after_027").gameObject;

		BoolObjA = GameObject.Find("PartsA");
		BoolObjE = GameObject.Find("PartsE");
	}
	
	// Update is called once per frame
	void Update () {
		try{
		Break_forLB_A scriptA = BoolObjA.GetComponent<Break_forLB_A>();
		Break_forLB_E scriptE = BoolObjE.GetComponent<Break_forLB_E>();		

		BoolA = scriptA.signA;
		BoolE = scriptE.signE;

		if(BoolA == true && BoolE == true){
			if(rigidbody == null){
			transform.gameObject.AddComponent("Rigidbody");
			transform.parent = null;
			}
		}
		}catch(System.Exception e){}
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			if(rigidbody == null){
			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");
			AconeD.AddComponent("Rigidbody");
			AconeE.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeD.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeE.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;
			AconeD.transform.parent = null;
			AconeE.transform.parent = null;

			fragment.SetActive(true);
			signG = true;
			}
		}
		}catch(System.Exception e){}
	}
}