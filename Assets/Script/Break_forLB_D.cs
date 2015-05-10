using UnityEngine;
using System.Collections;

public class Break_forLB_D : MonoBehaviour {

public bool signD = false;

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
			transform.parent = null;
			}
		}
		}catch(System.Exception e){}
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Longboard_after_017").gameObject;
		GameObject AconeB = transform.FindChild("Longboard_after_012").gameObject;
		GameObject AconeC = transform.FindChild("Longboard_after_014").gameObject;
		GameObject AconeD = transform.FindChild("Longboard_after_038").gameObject;
		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			if(rigidbody == null){
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
			signD = true;
			}}
		}catch(System.Exception e){}
	}
}