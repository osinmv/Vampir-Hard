using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Updated is called fixed amount of times per
    private void FixedUpdate()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.right = new Vector2(mouse.x - gameObject.transform.position.x, mouse.y - gameObject.transform.position.y);
        rb.velocity = new Vector2( Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime);
    }
}
