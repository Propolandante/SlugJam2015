using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

    public GameObject paper;
    public GameObject debug;
    public GameObject painter;
    HandwritingPainter painterScript;
	public AIBehavior ai_behavior;

    public float mx;
    public float my;
    float prevMx;
    float prevMy;

    public bool mouseDown = false;
    bool wasMouseDown = false;
	bool needToSave = false;
	float lastMouseUp = 0.0f;  //Timestamp

	// Use this for initialization
	void Start () {
        painterScript = painter.GetComponent<HandwritingPainter>();

		//Cursor.visible = false;
	}

	void Update ()
    {
        mouseDown = Input.GetMouseButton(0);
        if (Input.GetMouseButtonDown(1))
        {
			ai_behavior.turn_the_page();
        }

        updatePosition();
        checkMargin();
        handleClick();

        wasMouseDown = mouseDown;
    }

    void updatePosition()
    {
        prevMx = mx;
        prevMy = my;
        mx = (Input.mousePosition.x / Screen.width);
        my = (Input.mousePosition.y / Screen.height);
        float x = (mx-.5f) * paper.transform.localScale.x;
        float y = (my-.5f) * paper.transform.localScale.z ;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, y, 0);
    }

    void checkMargin()
    {
        if (over_margin())
            debug.transform.position = new Vector3(1.65f, 3, -8.35f);
        else
            debug.transform.position = new Vector3(1.65f, 1.5f, -8.35f);
    }

	public bool over_margin() {
		return over_margin(new Vector2(mx, my));
	}
	public bool over_margin(Vector2 v) {
		return v.x < 0.3;
	}

    void handleClick()
    {
        if (mouseDown)
        {
			needToSave = true;

			if(over_margin())
				ai_behavior.acknowledged = true;

            if (wasMouseDown)
            {
                if (getScreenCoords() != getPrevScreenCoords())
                {
                    painterScript.writeLine(getScreenCoords(), getPrevScreenCoords());
                }
            }
            else
            {
                painterScript.writeDot(getScreenCoords());
            }
        }

		if(!mouseDown && wasMouseDown)
			lastMouseUp = Time.time;

        if(needToSave  &&  !mouseDown  &&  Time.time >= lastMouseUp + 1f)
        {
			Debug.Log("Saving: " + Time.time);
			needToSave = false;
            painterScript.SaveTexture();
        }
    }

    public Vector2 getScreenCoords()
    {
        return new Vector2(mx, my);
    }

    public Vector2 getPrevScreenCoords()
    {
        return new Vector2(prevMx, prevMy);
    }
}
