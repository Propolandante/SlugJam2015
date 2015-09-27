using UnityEngine;
using System.Collections;

public class AIBehavior : MonoBehaviour {

    public HandwritingPainter painter;
	public GameObject paper;

    void Start()
    {
        startAnimation(Animations.anims[1]);
    }

    public class Motion
    {
        public enum Type { MOVED, DRAGGED, DOT }
        public Vector2 pos;
        public float time;
        public Type type;
        public Motion(string s, float t, float x, float y)
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

	Vector2 hand_position = new Vector2(-3, 0);
    void moveHand(Vector2 v)
    {
        float x = (v.x-.5f) * paper.transform.localScale.x * -1f;
        float y = (v.y-.5f) * paper.transform.localScale.z * -1f;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, 0, y);
		hand_position = v;
    }
    AIState state;

    class Idling : AIState
    {
        public static Idling instance = new Idling();
        public void update() { }
        private Idling() { }
    }
	class MovingLinearly : AIState {
		Vector2 dest;
		AIBehavior parent;
		float speed;
		AIState next;
		public MovingLinearly(Vector2 d, float s, AIBehavior p, AIState n) {
			dest = d;
			parent = p;
			speed = s;
			next = n;
		}
		public void update() {
			float dt = Time.deltaTime;

			Vector2 total_displace = dest - parent.hand_position;
			Vector2 partial_displace = total_displace.normalized * speed * dt;
			if(total_displace.sqrMagnitude <= partial_displace.sqrMagnitude) {
				parent.moveHand(dest);
				parent.state = next;
			} else {
				parent.moveHand(parent.hand_position + partial_displace);
			}
		}
	}
    class Animating : AIState
    {
        int frame;
        float start_time;
        Motion[] animation;
        AIBehavior parent;
        public Animating(Motion[] a, AIBehavior p)
        {
            frame = 0;
            start_time = Time.time;
            animation = a;
            parent = p;
        }

        public void update()
        {
            float time = Time.time;
            while (time - start_time >= 1f/2.5f/1000f*animation[frame + 1].time)
            {
                ++frame;

                float scale = 1f / 640f;
                switch (animation[frame].type)
                {
                    case Motion.Type.DOT:
                        parent.painter.writeDot(pen_transform(animation[frame].pos));
                        break;
                    case Motion.Type.DRAGGED:
                        parent.painter.writeLine(pen_transform(animation[frame - 1].pos), pen_transform(animation[frame].pos));
                        break;
                }

                if (frame == animation.Length - 1)
                {
                    parent.state = new MovingLinearly(new Vector2(-3, 0), 3f, parent, Idling.instance);
                    break;
                }
            }

            parent.moveHand(pen_transform(animation[frame].pos));
        }
    }
	private static Vector2 pen_transform(Vector2 v)
	{
		return new Vector2(v.x / 640f, 1 - v.y / 640f);
	}

    interface AIState
    {
        void update();
    }
    public void startAnimation(Motion[] animation)
    {
        state =
			new MovingLinearly(pen_transform(animation[0].pos), 3f, this,
			new Animating(animation, this) );
    }

    void Update()
    {
        state.update();
    }
}
