using UnityEngine;
using System.Collections;

public class CubeLoopB : MonoBehaviour {

	// Use this for initialization
	private void Start () {
		AnimationClip clip = new AnimationClip();

		AnimationCurve curveAL_y = AnimationCurve.Linear(0f,3.5f,1f,3.5f);
		clip.SetCurve("", typeof(Transform), "localPosition.x", curveAL_y);

		AnimationCurve curveAL_z = AnimationCurve.Linear(0f,5f,1f,5f);
		clip.SetCurve("", typeof(Transform), "localPosition.z", curveAL_z);

		AnimationCurve curve = AnimationCurve.EaseInOut(0f,-1.0f,3.2f,-0.6f);
		clip.SetCurve("", typeof(Transform), "localPosition.y", curve);
		clip.wrapMode = WrapMode.PingPong;
		animation.AddClip(clip,"clip_point");
		animation.Play("clip_point");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
