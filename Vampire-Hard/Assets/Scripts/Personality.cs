using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personality : MonoBehaviour
{
    public bool drunk = false;
    public bool cross = false;
    public bool garlic = false;
    public bool silver = false;
    public bool set_goal = false;
    public Vector2 current_goal;
    public float time_for_action = 10f;
    private Rigidbody2D rgb;

    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 vect = new Vector2(current_goal.x - gameObject.transform.position.x, current_goal.y - gameObject.transform.position.y);
        gameObject.transform.right = new Vector2(current_goal.x - gameObject.transform.position.x, current_goal.y - gameObject.transform.position.y);
        rgb.velocity = vect;

    }
    public void setTarget(Vector2 target)
    {
        current_goal = target;
    }


}
