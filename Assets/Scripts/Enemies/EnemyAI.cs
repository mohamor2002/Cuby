using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float speed;
	static public bool movingright = true;
	public Transform Castpoint;
	public float distance;

	void FixedUpdate ()
	{
		transform.Translate(Vector2.right * speed * Time.deltaTime);
		RaycastHit2D Info = Physics2D.Raycast(Castpoint.position, Vector2.down, distance); 
		if (Info.collider ==null)
		{
			if (movingright == true)
			{
				transform.eulerAngles = new Vector3(0, 180, 0);
				movingright = false; 
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				movingright = true;
			}
		}
		
	}



}
