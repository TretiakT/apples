using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
	public static float bottonY = -20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottonY) 
		{Destroy (this.gameObject);
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker> ();
			apScript.AppleDestroyed ();}
	}
}
