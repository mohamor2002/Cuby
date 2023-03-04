using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrEars : MonoBehaviour {

	public LayerMask Player;
	public Transform Castpoint;
	public float Radius;
	bool Detected = false ;
	GameManager gm;

	

	// Use this for initialization
	void Start () {
		gm = FindObjectOfType<GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		Detected = Physics2D.OverlapCircle(Castpoint.position, Radius, Player );
		if ( Detected==true )
		{
			gm.Caught();
			gm.Endgame();
			

		}

	}
}
