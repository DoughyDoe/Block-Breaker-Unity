using UnityEngine;
using System.Collections;

public class LevelManagerScript : MonoBehaviour 
{
	public void LoadLevel(string LevelName)
	{
		Debug.Log ("Level Load Requested For "+LevelName);
		Application.LoadLevel(LevelName);
	}
	public void QuitRequest()
	{
		Debug.Log ("Requesting Quit");
		Application.Quit();
	}
	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	

}
