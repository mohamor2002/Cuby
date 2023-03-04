using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	bool movingright = true ;
	public float Movevalue;
	public float movespeed;
	Vector3 Movepos;
	Vector3 CurrentPos;
	void Start()
	{
		Movepos.x = transform.position.x + Movevalue;
		CurrentPos.x = transform.position.x;
	}
	void Update () {

		
		if(movingright == true && transform.position.x < Movepos.x)
		{
			transform.Translate(Vector2.right * movespeed * Time.deltaTime);
			if ( transform.position.x >= Movepos.x) {
				movingright = false;
			}
		}
		if ( movingright == false )
		{
			transform.Translate(Vector2.left * movespeed * Time.deltaTime);
			if ( transform.position.x <= CurrentPos.x )
			{
				movingright = true;
			}
		}
	}
}
	
