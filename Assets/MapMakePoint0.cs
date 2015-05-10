using UnityEngine;
using System.Collections;

public class MapMakePoint0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
	if(collider.gameObject.name == "MainCamera"){
	GameObject Map2_2 = transform.Find("Map2_2").gameObject;
	Map2_2.SetActive(true);
	Map2_2.transform.parent = null;
		}
	}
}