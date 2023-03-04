using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MrEyes : MonoBehaviour {

    public Color seecolor ;
	public Color donotseecolor;
	public GameObject SightLine;
	public Transform startpoint;
	public float range;
	
	GameObject Player;
	GameManager gm;
	

	


	void Start ()
	{
		Physics2D.queriesStartInColliders = false;
		gm = FindObjectOfType<GameManager>();
		
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	void Update ()
	{
		if (EnemyAI.movingright==true)
		{
			RaycastHit2D Info = Physics2D.Raycast(startpoint.position, Vector2.right, range);
			if (Info.collider == Player.GetComponent<Collider2D>())
			{


				gm.Caught();
				gm.Endgame();
				
				
			}
		}
		else
		{
			RaycastHit2D Info = Physics2D.Raycast(startpoint.position, Vector2.left, range);
			if (Info.collider == Player.GetComponent<Collider2D>())
			{


				gm.Caught();
				gm.Endgame();
				
			}
		}

	}
	


	}

