using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
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
        Debug.Log(Input.GetAxis("Vertical"));
        rb.velocity = new Vector2(0, Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2( Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime,0);
    }
}
