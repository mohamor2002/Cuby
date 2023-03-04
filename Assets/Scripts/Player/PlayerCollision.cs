using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	GameManager gm;
	public static Vector3 Checkpoint;
	bool saved;
	Animator anim;
	
 
	void Start () {
		gm = FindObjectOfType<GameManager>() ;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.collider.CompareTag("Death"))
		{
			
			gm.YouDied();
			gm.Endgame();
			
		}
		if (col.collider.CompareTag("MovingGround"))
		{
			this.transform.parent = col.transform;
		}
	}
	void OnCollisionExit2D ( Collision2D col )
	{
		if (col.collider.CompareTag("MovingGround"))
		{
			this.transform.parent = null;
		}
	}
	void OnTriggerEnter2D ( Collider2D other )
	{
		if ( other.tag == "Respawn")
		{
			Checkpoint = other.transform.position;
			
		}
	}
}
