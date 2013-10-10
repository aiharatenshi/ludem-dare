
using UnityEngine;
using System.Collections;
using System.Collections.Generic; //NEED THIS LINE TO MAKE ARRAYS

public class Spawner : MonoBehaviour {
	
	public UndeadTurn infected;
	public UndeadTurn human;
	public int spawnCount = 30;
	
	public static float white = 1f;
	public static float whitesaved = 0f;
	public static float whitelost = 0f;
	public GUIText display;
	
	public static bool iamdead = false;
	
	//array
	public List<UndeadTurn> spawnList= new List<UndeadTurn>();

	// Use this for initialization
	void Start () {
		int currentSpawnCounter = 0;
		while (currentSpawnCounter < spawnCount){
			//Spawn a fish
			Vector3 spawnPosition = new Vector3(Random.Range (-10f,10f), 2f, Random.Range (-20f, 0f) );

			//will instantiate blueprint, at this position, with no rotation
			// makes variables. Need to do "as Fish" to cast this OBJECT as a FISH. because instantiate = type Object
			float random = Random.Range (0f, 20f);
			if (random < 1f){
			UndeadTurn newSpawn = Instantiate (infected, spawnPosition, Quaternion.identity) as UndeadTurn;
			spawnList.Add (newSpawn);

			}

			else {
				UndeadTurn newSpawn = Instantiate (human, spawnPosition, Quaternion.identity) as UndeadTurn;
				spawnList.Add (newSpawn);
				white ++;

			}

			//adds fish to a list! woot!


			currentSpawnCounter ++;
		}


	}
	
	void Update(){
		if (iamdead == false){
		if (white <=0){
			
			display.text = "Pure saved = " + Spawner.whitesaved.ToString() + " and Pure lost = " + Spawner.whitelost.ToString();
			
			}
		}
	}
}