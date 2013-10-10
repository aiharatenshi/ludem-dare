using UnityEngine;
using System.Collections;

public class SpotlightFix : MonoBehaviour {
	public Light spotlight;
	public Camera followCamera;
	//var lightpos = spotlight.transform;
	//var mypos = transform;
	public Vector3 lightOffset =  new Vector3(0f, 10f , 0f);
	public Vector3 cameraOffset = new Vector3(0f, 8f, -1f);
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	spotlight.transform.position = transform.position + lightOffset;
	followCamera.transform.position = transform.position + cameraOffset;
	}
}
