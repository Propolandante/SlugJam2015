using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

    GameObject paper = null;
    GameObject debug = null;

    public float mx;
    public float my;

	// Use this for initialization
	void Start () {
        paper = GameObject.Find("Paper");
        debug = GameObject.Find("Debug");
	}

	void FixedUpdate () {
        mx = (Input.mousePosition.x / Screen.width);
        my = (Input.mousePosition.y / Screen.height);
        float x = (mx-.5f) * paper.transform.localScale.x * -1f;
        float y = (my-.5f) * paper.transform.localScale.z * -1f;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, 0, y);
        if (mx < 0.3)
            debug.transform.position = new Vector3(1.65f, 3, -8.35f);
        else
            debug.transform.position = new Vector3(1.65f, 1.5f, -8.35f);
    }

    public Vector2 getScreenCoords()
    {
        return new Vector2(mx, my);
    }
}
