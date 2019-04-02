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
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Walking", false);
            started_sucking = true;
        }

        if (started_sucking)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                animator.SetBool("Walking", true);
                started_sucking = false;
                timer = 0;
            }
        }
        

    }

    // Updated is called fixed amount of times per
    private void FixedUpdate()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.right = new Vector2(mouse.x - gameObject.transform.position.x, mouse.y - gameObject.transform.position.y);
        rb.velocity = new Vector2( Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime);
    }
}
