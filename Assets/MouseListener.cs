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

    class Motion
    {
        public enum Type {MOVED, DRAGGED, DOT}
        public Vector2 pos;
        public float time;
        public Type type;
        Motion(string s, float t, float x, float y)
        {
            pos = new Vector2(x, y);
            time = t;
            if (s == "moved")
                type = Type.MOVED;
            else if (s == "dragged")
                type = Type.DRAGGED;
            else if (s == "dot")
                type = Type.DOT;
        }
    }

    void moveHand(Vector2 v)
    {

    }
    AIState state;

    class Idling : AIState
    {
        public static Idling instance = new Idling();
        public void update() {}
        private Idling() {}
    }
    class Animating : AIState
    {
        int frame;
        float start_time;
        Motion[] animation;
        MouseListener parent;
        public Animating(Motion[] a, MouseListener p)
        {
            frame = 0;
            start_time = Time.time;
            animation = a;
            parent = p;
        }

        public void update()
        {
            float time = Time.time;
            while (time - start_time < animation[frame + 1].time)
            {
                ++frame;

                switch(animation[frame].type)
                {
                    case Motion.Type.DOT:
                        writeDot(animation[frame].pos);
                        break;
                    case Motion.Type.DRAGGED:
                        writeLine(animation[frame-1].pos, animation[frame].pos);
                        break;
                }
            }

            parent.moveHand(animation[frame].pos);
        }
    }
    interface AIState
    {
        void update();
    }
    void startAnimation(Motion[] animation)
    {
        state = new Animating(animation, this);
    }

    void Update()
    {
        state.update();
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
