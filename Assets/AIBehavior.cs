using UnityEngine;
using System.Collections;

public class AIBehavior : MonoBehaviour {

    public HandwritingPainter painter;
	public GameObject paper;
	public MouseListener mouse_listener;

	public static int RESOLUTION = 100;
	public bool[] available_space;

    void Start()
    {
		curr_msg = 1;
		acknowledged = false;
		available_space = new bool[RESOLUTION];

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
        float x = (v.x-.5f) * paper.transform.localScale.x;
        float y = (v.y-.5f) * paper.transform.localScale.z;
        transform.position = paper.transform.position + paper.transform.rotation * new Vector3(x, y, 0);
		hand_position = v;
    }
    AIState state;
	int curr_msg;  // Current index into the array: Animations.anims
	public bool acknowledged;  // Has the player "acknowledged" the current message yet?

    class Idling : AIState
    {
		AIBehavior parent;
        public void update() {
			if(      parent.acknowledged
			      && !parent.mouse_listener.over_margin()
				  && !parent.mouse_listener.mouseDown     ) {
				if(parent.curr_msg < Animations.anims.Length) {
					parent.acknowledged = false;
					++parent.curr_msg;
				}
				// Second if-statement is not redundant because
				// parent.curr_msg can change.
				if(parent.curr_msg < Animations.anims.Length) {
					parent.startAnimation(Animations.anims[parent.curr_msg]);
				}
			}
		}
        public Idling(AIBehavior p) {parent = p;}
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
		Vector2 offset;

		private void end() {
			parent.state = new MovingLinearly(new Vector2(-3, 0), 3f, parent, new Idling(parent));
		}

        public Animating(Motion[] a, Vector2 off, AIBehavior p)
        {
            frame = 0;
            start_time = Time.time;
            animation = a;
            parent = p;
			offset = off;
        }

        public void update()
        {
			// Check if the animation was over before it began
			if(animation.Length == 1) {
				end();
				return;
			}

            float time = Time.time;
            while (time - start_time >= 1f/1f/1000f*animation[frame + 1].time)
            {
                ++frame;

                float scale = 1f / 640f;
                switch (animation[frame].type)
                {
                    case Motion.Type.DOT:
                        parent.painter.writeDot(offset+pen_transform(animation[frame].pos));
                        break;
                    case Motion.Type.DRAGGED:
                        parent.painter.writeLine(offset+pen_transform(animation[frame - 1].pos), offset+pen_transform(animation[frame].pos));
                        break;
                }

                if (frame == animation.Length - 1) {
					end();
                    break;
                }
            }

            parent.moveHand(offset+pen_transform(animation[frame].pos));
        }
    }

	private static Vector2 pen_transform(Vector2 v)
	{
		return new Vector2((v.x-90) / 640f, 1 - (v.y-90) / 640f);
	}

    interface AIState
    {
        void update();
    }

	private void turn_the_page() {
		available_space = new bool[RESOLUTION];
	}

	private Vector2 find_available_space() {
		int RUN_LENGTH = 7;
		int run = 0;
		for(int i=0; i<available_space.Length; ++i) {
			if(!available_space[i]) {
				++run;
				if(run == RUN_LENGTH) {
					return new Vector2(0, (float)(RUN_LENGTH-i-1)/RESOLUTION);
				}
			} else {
				run = 0;
			}
		}
		turn_the_page();
		return Vector2.zero;
	}

    public void startAnimation(Motion[] animation)
    {
		Vector2 offset = find_available_space();
        state =
			new MovingLinearly(offset+pen_transform(animation[0].pos), 3f, this,
			new Animating(animation, offset, this) );
    }

    void Update()
    {
        state.update();
    }
}
