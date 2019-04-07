using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personality : MonoBehaviour
{
    public bool drunk = false;
    public bool cross = false;
    public bool garlic = false;
    public bool silver = false;
    //public bool set_goal = false;
    private Vector2 current_goal;
    public float time_for_action = 10f;
    private Rigidbody2D rgb;
    public float speed = 500f;
    public bool reached_goal = false;
    private float length_to_goal;
    public bool in_event =false;
    public Animator anim;
    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
       

    }
    void FixedUpdate()
    {
        if (!in_event)
        {
            if (Mathf.Sqrt(Mathf.Pow(rgb.position.x - current_goal.x, 2) + Mathf.Pow(rgb.position.y - current_goal.y, 2)) < 1f)
            {
                reached_goal = true;
            }
            else
            {
                Vector2 vect = new Vector2((current_goal.x - gameObject.transform.position.x), current_goal.y - gameObject.transform.position.y);
                gameObject.transform.right = vect;

                rgb.MovePosition(rgb.position + vect * Time.fixedDeltaTime * 0.5f);
            }
        }
        else
        {
            rgb.velocity = new Vector2(0,0);
        }
    }
    public void setTarget(Vector2 target)
    {
       
        current_goal = target;
        reached_goal = false;
    }
    public void set_drunk()
    {
        drunk = true;
        in_event = false;
    }
    public void set_silver()
    {
        silver = true;
        in_event = false;
    }
    public void set_cross()
    {
        cross = true;
        in_event = false;
    }
    public void set_garlic()
    {
        garlic = true;
        in_event = false;
    }
    public void set_animation_alc()
    {
        CancelInvoke();
        anim.Play("Alc");
        Invoke("set_drunk",1f);
    }
    public void set_animation_cross()
    {
        CancelInvoke();
        anim.Play("Cross");
        Invoke("set_cross", 1f);
    }
    public void set_animation_silver()
    {
        CancelInvoke();
        anim.Play("Silver");
        Invoke("set_silver", 1f);
    }
    public void set_animation_garlic()
    {
        CancelInvoke();
        anim.Play("Garlic");
        Invoke("set_garlic", 1f);
    }
}
