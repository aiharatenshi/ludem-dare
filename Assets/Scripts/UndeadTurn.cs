using UnityEngine;
using System.Collections;

public class UndeadTurn : MonoBehaviour {
	public Vector3 destination = new Vector3 (0f, 2f, 0f);
	public float speed = 5f;
	public Material mold;
	public AudioSource drop;
	
	
	//public static float white;
	public GUIText display;

	
	

	// Use this for initialization
	void Start () {
	InvokeRepeating ("SetNewDestination", 0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
	
	void FixedUpdate(){
		Vector3 direction = Vector3.Normalize (destination - transform.position);

		//awkward zooming of fish to get to its destination	
		//rigidbody.AddForce( destination - transform.position );
		//rigidbody.AddForce(destination);
		rigidbody.AddForce (direction *speed, ForceMode.VelocityChange);
}
	

	void SetNewDestination(){
		destination = new Vector3 (Random.Range (-10f,10f), 2f, Random.Range (-20f, 0f) );
	}
	
	
	
	void OnTriggerEnter(Collider other) {
		if (gameObject.tag == "Cube"){
			if(Spawner.iamdead == false){
			if (other.tag == "Ball"){
				drop.audio.Play();
				Destroy (gameObject);
				Spawner.white --;
				Spawner.whitesaved ++;
				
				
				
				display.text = "Pure Left = " + Spawner.white.ToString ();
				
					}
			
			if (other.tag == "NotCube"){
				gameObject.tag = "NotCube";
				gameObject.renderer.material = mold;
				audio.Play();
				Spawner.white--;
				Spawner.whitelost ++;
				
					
				
				display.text = "Pure Left = " + Spawner.white.ToString();
				
				}
			}
		}
		
		if (gameObject.tag == "NotCube"){
			
			
			if(other.tag == "Ball"){
				Spawner.iamdead = true;
				Destroy (other.gameObject);
				
				display.text = "You died. You saved " + Spawner.whitesaved.ToString () + " Pure before you died.";
				
			}
		}
		
	}
		
}
