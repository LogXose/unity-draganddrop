using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDragAndDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Drag()
	{
		GameObject.Find ("Image").transform.position = Input.mousePosition;
		print ("We are dragging the Mouse");
	}

	public void Drop()
	{ 
		GameObject bosluk = GameObject.Find ("Bosluk");
		float distance = Vector2.Distance (GameObject.Find ("Image").transform.position, bosluk.transform.position);
		if (distance < 50) {
			GameObject.Find ("Image").transform.position = bosluk.transform.position;
		}

	}

}
