using UnityEngine;
using System.Collections;

public class LBLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AnimationClip clip = new AnimationClip();

		AnimationCurve curveAL_x = AnimationCurve.EaseInOut(0f,2.7f,5f,-2.7f);
		clip.SetCurve("", typeof(Transform), "localPosition.x", curveAL_x);

		AnimationCurve curveAL_z = AnimationCurve.Linear(0f,-0.3f,1f,-0.3f);
		clip.SetCurve("", typeof(Transform), "localPosition.z", curveAL_z);

		AnimationCurve curve = AnimationCurve.Linear(0f,-4.7f,1f,-4.7f);
		clip.SetCurve("", typeof(Transform), "localPosition.y", curve);
		clip.wrapMode = WrapMode.PingPong;
		animation.AddClip(clip,"clip_point");
		animation.Play("clip_point");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
