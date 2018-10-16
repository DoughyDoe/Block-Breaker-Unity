using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManagerScript LevelManager;
	
	void Start()
	{
		LevelManager = GameObject.FindObjectOfType<LevelManagerScript>();
	}
	void OnCollisionEnter2D (Collision2D Collision)
	{
		print ("Collision");
		
	}
	
	void OnTriggerEnter2D (Collider2D Trigger)
	{
		print ("Trigger");
		LevelManager.LoadLevel ("Lose");
	}	
}
