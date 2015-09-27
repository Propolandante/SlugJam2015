using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

    GameObject paper = null;
    GameObject debug = null;
    public GameObject painter;
    HandwritingPainter painterScript;
	public AIBehavior ai_behavior;

    public float mx;
    public float my;
    float prevMx;
    float prevMy;

    public bool mouseDown = false;
    bool wasMouseDown = false;

	// Use this for initialization
	void Start () {
        paper = GameObject.Find("Paper");
        debug = GameObject.Find("Debug");
        painterScript = painter.GetComponent<HandwritingPainter>();

		Cursor.visible = false;
	}

	void Update ()
    {
        mouseDown = Input.GetMouseButton(0);

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
        float x = (mx-.5f) * paper.transform.localScale.x * -1f;
        float y = (my-.5f) * paper.transform.localScale.z * -1f;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, 0, y);
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

        if (!mouseDown && wasMouseDown)
        {
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
