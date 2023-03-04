using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

	public float upvalue;
	public float upspeed;
	Vector3 Stop;
	bool Up = false;
	bool upp;
	public Transform point;


	public float radius;
	public LayerMask Hero;
	float input;
	bool Elev = false;


	
	void Start ()
	{
		Stop.x = transform.position.x;
		Stop.y = transform.position.y + upvalue;
		Stop.z = transform.position.z;
		
	}
	void Update () {
		input = Input.GetAxisRaw("Vertical");
		if ( input >0)
		{
			Elev = true;
		}
		Up = Physics2D.OverlapCircle(point.position, radius, Hero);
		if (Up == true)
		{
			upp = true;
		}

		if ( upp ==true && transform.position.y < Stop.y && Elev==true  )
		{
			transform.Translate( Vector2.up * upspeed * Time.deltaTime );
			
		}
		if (transform.position.y >= Stop.y )
		{
			transform.position = Stop;
		}
		
		
	}
	

}
