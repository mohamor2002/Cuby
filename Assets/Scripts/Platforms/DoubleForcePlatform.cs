using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleForcePlatform : MonoBehaviour {
	
	Vector3 Currentpos;
	Vector3 DownPos;
	public float downvalue;
	public float downspeed;
	bool Downtime= false ;
	bool Playerin = false;
	public static bool doublejumpforce = false ;
	public float radius;
	public LayerMask player;
	public Transform point;
	
	

	void Start () {
		Currentpos = transform.position ;
		DownPos.x = transform.position.x;
		DownPos.y = transform.position.y - downvalue ;
		DownPos.z = transform.position.z;

		
	}
	void Update()
	{
		Playerin = Physics2D.OverlapCircle( point.position, radius, player);
		

		if ( Playerin ==true )
		{
			
			doublejumpforce = true;
		}
		else if (Playerin == false)
		{
			doublejumpforce = false;
			
		}


		
	}

	
}
