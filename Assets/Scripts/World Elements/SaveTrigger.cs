using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTrigger : MonoBehaviour {

	 GameObject Player;
	string Scene;
	void Start ()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void OnTriggerEnter2D ( Collider2D other)
	{
		if ( other.tag == "Player")
		{
			ES3.Save<Vector3>("PlayerPos" , Player.transform.position);
			ES3.Save<string>("CurrentScene", SceneManager.GetActiveScene().name);
		}
	}
	public void Load ()
	{
		Scene = ES3.Load<string>("CurrentScene");
		SceneManager.LoadScene(Scene);
		Player.transform.position = ES3.Load<Vector3>("PlayerPos");
	}
}
