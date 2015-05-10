using UnityEngine;
using System.Collections;

public class MapMakePoint1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
	if(collider.gameObject.name == "MainCamera"){
	GameObject Map2_1 = transform.Find("Map1_2").gameObject;
	Map2_1.SetActive(true);
	Map2_1.transform.parent = null;
		}
	}
}