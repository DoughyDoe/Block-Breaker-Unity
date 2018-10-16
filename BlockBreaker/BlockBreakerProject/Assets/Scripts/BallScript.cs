using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour 
{
	private PaddleScript paddle;
	private bool Launched=false;
	
	private Vector3 PaddleToBallVector;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<PaddleScript>();
		PaddleToBallVector = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Launched == false)
		{
			this.transform.position = paddle.transform.position + PaddleToBallVector;
		
			if (Input.GetMouseButtonDown(0))
			{
				Launched = true;
				print ("Mouse Clicked, Launching Ball");
				this.rigidbody2D.velocity = new Vector2 (2f,10f);
			}
		}
	}
}
