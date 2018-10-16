using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour 
{
	
	public Sprite[] HitSprites;
	private int TimesHit;
	private LevelManagerScript LevelManager;
	// Use this for initialization
	void Start () 
	{
		TimesHit = 0;
		LevelManager = GameObject.FindObjectOfType<LevelManagerScript>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnCollisionEnter2D (Collision2D Collision)
	{
		bool IsBreakable = (this.tag == "Breakable");
		if (IsBreakable)
		{
			HandleHits ();	
		}
		//TODO Remove This Method Once We Can Win	
	}
	void HandleHits()
	{
		int MaxHit = HitSprites.Length +1;
		TimesHit++;
		if (TimesHit >= MaxHit)
		{
			Destroy (gameObject);
		}
		else
		{
			LoadSprites();
		}
	}
	void LoadSprites()
	{
		int SpriteIndex = TimesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = HitSprites [SpriteIndex];	
	}
	
	void SimulateWin()
	{
		LevelManager.LoadNextLevel();
	}
}
