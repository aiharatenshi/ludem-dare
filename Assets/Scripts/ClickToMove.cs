

using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	public float stoppingdistance = 1f;
	public Vector3 goHere = new Vector3(5f, 3f, 0f);
	public float speed = 5f;	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update(){
		Ray cursorRay = Camera.main.ScreenPointToRay(Input.mousePosition) ;
		RaycastHit rayHit = new RaycastHit();
		
		if (Input.GetKey (KeyCode.Mouse0)){
			if (Physics.Raycast(cursorRay, out rayHit, 10000000f)){
			goHere = rayHit.point;
			}
					
			
	}
	}
	
	void FixedUpdate () {
	
		float movingDistance = Vector3.Distance (goHere, transform.position);
		//float movingDistance = Vector3.magnitude (goHere - transform.position);
		
		//print (movingDistance > stoppingdistance);
		
		if (movingDistance > stoppingdistance){
			Vector3 direction = Vector3.Normalize( goHere - transform.position );
        	rigidbody.AddForce( direction * speed);
			
			
		}
		
		
	}
	
	//void OnTriggerEnter (Collider other){
		//if (other.tag == "NotCube"){
			//Destroy (gameObject);
		//}
	//}
	//public void SetNewDestination (Vector3 newDestination) {
        //destination = newDestination;
    //}
}
