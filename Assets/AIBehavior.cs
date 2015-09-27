using UnityEngine;
using System.Collections;

public class AIBehavior : MonoBehaviour {

    public HandwritingPainter painter;

    void Start()
    {
        startAnimation(Animations.anim_1);
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

    void moveHand(Vector2 v)
    {

    }
    AIState state;

    class Idling : AIState
    {
        public static Idling instance = new Idling();
        public void update() { }
        private Idling() { }
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
            while (time - start_time < animation[frame + 1].time)
            {
                ++frame;

                switch (animation[frame].type)
                {
                    case Motion.Type.DOT:
                        parent.painter.writeDot(animation[frame].pos);
                        break;
                    case Motion.Type.DRAGGED:
                        parent.painter.writeLine(animation[frame - 1].pos, animation[frame].pos);
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
}
