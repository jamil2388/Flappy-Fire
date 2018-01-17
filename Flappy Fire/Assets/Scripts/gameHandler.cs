using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameHandler : MonoBehaviour
{
	//public vars
	

	//private vars
	//to enable monitoring touch input
	private bool handleTouch;
	//to store the touch value
	private Touch touch;

	// Use this for initialization
	void Start ()
	{
		handleTouch = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (handleTouch) {
			executeTouch ();
		}
	}

	//to handle the touch activities
	void executeTouch ()
	{
		if (Input.touchCount > 0) {
			touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				print ("the player should jump here");
			}
		}
	}
}
