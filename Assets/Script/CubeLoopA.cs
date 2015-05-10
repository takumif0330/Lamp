using UnityEngine;
using System.Collections;

public class CubeLoopA : MonoBehaviour {

	// Use this for initialization
	private void Start () {
		AnimationClip clip = new AnimationClip();

		AnimationCurve curveAL_y = AnimationCurve.Linear(0f,-2.5f,1f,-2.5f);
		clip.SetCurve("", typeof(Transform), "localPosition.x", curveAL_y);

		AnimationCurve curve = AnimationCurve.EaseInOut(0f,-0.1f,3f,-0.6f);
		clip.SetCurve("", typeof(Transform), "localPosition.y", curve);
		clip.wrapMode = WrapMode.PingPong;
		animation.AddClip(clip,"clip_point");
		animation.Play("clip_point");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
