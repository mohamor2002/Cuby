using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Won : MonoBehaviour {
	GameManager gm;
	void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}
	
	void OnTriggerEnter2D (Collider2D Col)
	{
		if(Col.gameObject.tag == "Player")
		{
			gm.Demo();
		}
	}
}
