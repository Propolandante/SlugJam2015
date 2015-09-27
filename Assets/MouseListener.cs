using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

    public GameObject paper;
    public GameObject debug;
    public GameObject painter;
    HandwritingPainter painterScript;

    public float mx;
    public float my;
    float prevMx;
    float prevMy;

    bool mouseDown = false;
    bool wasMouseDown = false;

	// Use this for initialization
	void Start () {
        painterScript = painter.GetComponent<HandwritingPainter>();
	}

	void Update () 
    {
        mouseDown = Input.GetMouseButton(0);
        if (Input.GetMouseButtonDown(1))
        {
            GameObject.Find("Paper Stack").GetComponent<PaperController>().nextPage();
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
        if (mx < 0.3)
            debug.transform.position = new Vector3(1.65f, 3, -8.35f);
        else
            debug.transform.position = new Vector3(1.65f, 1.5f, -8.35f);
    }

    void handleClick()
    {
        if (mouseDown)
        {
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
