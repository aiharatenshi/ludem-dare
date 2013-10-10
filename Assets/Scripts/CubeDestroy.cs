using UnityEngine;
using System.Collections;

public class CubeDestroy : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Ball")){
		Destroy (gameObject);
		}
}
}
	
