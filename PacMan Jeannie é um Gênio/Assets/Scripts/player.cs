using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	float speed  = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		MoveKeyboard ();
		
	}

	void MoveKeyboard ()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Rigidbody2D rigi2d = GetComponent<Rigidbody2D> ();

		//O player não fica seguindo constantemente em uma direção, ele serve como um peso sobre o player após a movimentação
		rigi2d.drag = 800;

		if (horizontal > 0) 
		{
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);
		}

		if (horizontal < 0) 
		{
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);
		}

		if (vertical > 0) 
		{
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);
		}

		if (vertical < 0) 
		{
			rigi2d.velocity = new Vector2 (horizontal * speed, vertical * speed);
		}



	}
}
