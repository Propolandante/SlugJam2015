using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Scale(Input.mousePosition,
		                                   new Vector3(1.0f/Screen.width, 1.0f/Screen.height, 1));
	}
}
