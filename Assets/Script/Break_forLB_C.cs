using UnityEngine;
using System.Collections;

public class Break_forLB_C : MonoBehaviour {

public bool signC = false;

	GameObject BoolObjA;
	GameObject BoolObjE;

	bool BoolA;
	bool BoolE;


	// Use this for initialization
	void Start () {
		BoolObjA = GameObject.Find("PartsA");
		BoolObjE = GameObject.Find("PartsE");

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
			}
		}
	}catch(System.Exception e){}
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Longboard_after_010").gameObject;
		GameObject AconeB = transform.FindChild("Longboard_after_025").gameObject;
		GameObject AconeC = transform.FindChild("Longboard_after_034").gameObject;
		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			if(rigidbody == null){
			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(-2, 0, 2, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;

			fragment.SetActive(true);
			signC = true;
			}}
		}catch(System.Exception e){}
	}
}