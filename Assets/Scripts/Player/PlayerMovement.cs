using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Movespeed;
	public static float Jumpforce;
	public float JumpforceValue;
	public float doubleforcevalue;
	private Rigidbody2D rb;
	private float input;
	private bool FacingRight = true ;
	private bool isgrounded;
	public Transform checkpoint;
	public float radius;
	public LayerMask ground;
	public static int extrajumps;
	public int extrajumpsvalue;
	public static int JumpPillvalue; 
	Animator anim ;
	bool jump;
	public float distance;
	
	
	




	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	
		doubleforcevalue = 2 * JumpforceValue;
		
		


		extrajumps = extrajumpsvalue + JumpPillvalue ;
	}


	void Update()
	{
		Jumpforce = JumpforceValue;
		if (DoubleForcePlatform.doublejumpforce == true) { JumpforceValue = doubleforcevalue; }
		if (DoubleForcePlatform.doublejumpforce == false) { JumpforceValue = doubleforcevalue/2 ; }





		input = Input.GetAxisRaw("Horizontal");
		jump = Input.GetButtonDown("Jump");

		isgrounded = Physics2D.OverlapCircle(checkpoint.position, radius, ground);
		if (jump && extrajumps > 0)

		{
			rb.velocity = Vector2.up * Jumpforce ; 
			
			extrajumps--;
		}
		else if (jump && extrajumps == 0 && isgrounded == true)
		{
			rb.velocity = Vector2.up * Jumpforce;
		}
		if (isgrounded == true)
		{
			extrajumps = extrajumpsvalue;
		}

	}

	void FixedUpdate()
	{
	
		

		rb.velocity = new Vector2(input * Movespeed, rb.velocity.y);

		if (FacingRight==false && input>0 )
		{
			Flip () ; 
		}
		else if (FacingRight==true && input<0)
		{
			Flip();
		}
		if (input == 0 && isgrounded == true) 
		{
			anim.SetBool("ismoving", false);
		}
		else
		{
			anim.SetBool("ismoving", true);
		}
		
	}


	void Flip()
	{
		FacingRight = !FacingRight;
		Vector3 Scale = transform.localScale;
		Scale.x *= -1;
		transform.localScale = Scale; 



	}

	


}