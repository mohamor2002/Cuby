using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twowaysPlatform : MonoBehaviour {

	private PlatformEffector2D effector;
	float input;
	bool jump;
	bool isup;

	void Start()
	{
		effector = GetComponent<PlatformEffector2D>();
		

	}
	  void Update ()
	{
		input = Input.GetAxisRaw("Vertical");
		jump = Input.GetButtonDown("Jump") ;
		if (input == -1 && isup ==true)
		{
			effector.rotationalOffset = 180f;
		}
		if (jump)
		{
			effector.rotationalOffset = 0;
		}
	}
	   void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			isup = true;
		}
	}


}
