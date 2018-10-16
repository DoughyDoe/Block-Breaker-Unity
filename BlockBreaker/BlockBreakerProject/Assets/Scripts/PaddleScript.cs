using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {
	public float MousePosInBlocks;
	public Vector3 PaddlePosInBlocks;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		MousePosInBlocks = (Input.mousePosition.x / Screen.width)*16;
		PaddlePosInBlocks = new Vector3 (0.5f,this.transform.position.y,0f);
		PaddlePosInBlocks.x = Mathf.Clamp(MousePosInBlocks,.5f,15.5f);
		this.transform.position = PaddlePosInBlocks;
	}
}
