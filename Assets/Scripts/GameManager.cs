using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	
	public float waittime;
	public GameObject Died;
	public GameObject caught;
	public GameObject demo;
	GameObject Player;
	Animator anim;
	SaveTrigger ST;



	void Start ()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		anim = Player.GetComponent<Animator>();
		ST = FindObjectOfType<SaveTrigger>();
		Player.transform.position = ES3.Load<Vector3>("PlayerPos");
	}

	
	
	void Menu()
	{
		SceneManager.LoadScene("Main Menu");
	}
	public void Endgame ()
	{
		
		Invoke("Load", waittime);
		
		
		
	}
	
	void Load ()
	{



		ST.Load();
		
		
		
	}

	public void YouDied ()
	{
		anim.SetBool("ishurt", true);
		Died.SetActive(true);
	}
	public void Caught ()
	{
		anim.SetBool("ishurt", true);
		caught.SetActive(true);
	}

	public void Demo()
	{
		demo.SetActive(true);
		Invoke("Menu", 2f);

	}
	
	
}
