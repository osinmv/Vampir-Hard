using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 500f;
    public bool started_sucking;
    public Animator animator;
    private float timer;
    public int health = 10;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.E)&&!started_sucking)
        {
            CancelInvoke();
            animator.Play("MainCharacterSuck",0);
            rb.velocity = new Vector2(0, 0);
            Invoke("set_Animation_walk",1);
            started_sucking = true;
        }

        


    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Personality a = collision.gameObject.GetComponent<Personality>();
        if ((collision.gameObject.name == "body_brown(Clone)" || collision.gameObject.name == "body_nicy(Clone)" || collision.gameObject.name == "body_soldier(Clone)") && started_sucking)
        {
            if (a.garlic && a.drunk)
            {
                score += 100;
                Destroy(collision.gameObject);
            }
            if (a.silver && a.cross)
            {
                health -= 1;
            }
            if (!a.garlic && !a.drunk && !a.silver && !a.cross)
            {
                score += 20;
                Destroy(collision.gameObject);
            }
            if (!a.garlic || !a.drunk || !a.silver || !a.cross)
            {
                score += 20;
                Destroy(collision.gameObject);
            }
        }
    }
    void set_Animation_walk()
    {
        animator.Play("Walking");
        started_sucking = false;
    }
    // Updated is called fixed amount of times per
    private void FixedUpdate()
    {
        if (!started_sucking)
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.right = new Vector2(mouse.x - gameObject.transform.position.x, mouse.y - gameObject.transform.position.y);
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime);
        }
        
    }
}
