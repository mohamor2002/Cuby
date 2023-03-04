using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
	public GameObject Current;
	public GameObject Next ;
	public SaveTrigger ST;
	public void Play ()
	{
		Next.SetActive(true);
		Current.SetActive(false);
	}
	public void Exit ()
	{
		Application.Quit();
	}
	public void Newgame ()
	{
		SceneManager.LoadScene("Level1");
		ES3.DeleteDirectory("PlayerPos") ;
	}
	public void Load ()
	{
		ST.Load();
	}
}
