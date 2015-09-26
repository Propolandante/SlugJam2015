using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

    GameObject paper = null;

	// Use this for initialization
	void Start () {
        paper = GameObject.Find("Paper");
        //transform.rotation = paper.transform.rotation.;

	}

	// Update is called once per frame
	void Update () {
        float x = Input.mousePosition.x / Screen.width - .5f;
        float y = Input.mousePosition.y / Screen.height - .5f;
        x *= paper.transform.localScale.x;
        y *= paper.transform.localScale.z;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, 0, y);
	}
}
