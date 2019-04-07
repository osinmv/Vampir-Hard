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
    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       

    }
    private void FixedUpdate()
    {
        if (Mathf.Sqrt(Mathf.Pow(rgb.position.x - current_goal.x, 2) + Mathf.Pow(rgb.position.y - current_goal.y, 2)) < 1f)
        {
            reached_goal = true;
        }
        else
        {
            Vector2 vect = new Vector2((current_goal.x - gameObject.transform.position.x), current_goal.y - gameObject.transform.position.y);
            gameObject.transform.right = vect;
            rgb.MovePosition(rgb.position + current_goal * Time.fixedDeltaTime / 5);
        }
    }
    public void setTarget(Vector2 target)
    {
        current_goal = target;
        reached_goal = false;
    }


}
